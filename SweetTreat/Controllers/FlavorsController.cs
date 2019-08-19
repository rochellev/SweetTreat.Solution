using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using SweetTreat.Models;

namespace SweetTreat.Controllers
{
    public class FlavorsController : Controller
    {
        private readonly SweetTreatContext _db;
        public FlavorsController(SweetTreatContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Flavors.ToList());
        }

        public ActionResult Details(int id)
        {
            var thisFlavor = _db.Flavors
                .Include(flavor => flavor.Treats)
                .ThenInclude(join => join.Treat)
                .FirstOrDefault(flavor => flavor.ID == id);
            return View(thisFlavor);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Flavor flavor, int TreatId)
        {
            _db.Flavors.Add(flavor);
            if (TreatId != 0)
            {
                _db.TreatFlavor.Add(new TreatFlavor() { TreatId = TreatId, FlavorId = flavor.ID });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}