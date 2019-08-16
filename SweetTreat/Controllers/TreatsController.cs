using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using SweetTreat.Models;

namespace SweetTreat.Controllers
{
    public class TreatsController : Controller
    {
        private readonly SweetTreatContext _db;
        public TreatsController(SweetTreatContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Treats.ToList());
        }

        public ActionResult Details(int id)
        {
            var thisTreat = _db.Treats
                .Include(treat => treat.Flavors)
                .ThenInclude(join => join.Flavor)
                .FirstOrDefault(treat => treat.ID == id);
            return View(thisTreat);
        }

        public ActionResult Create()
        {
            ViewBag.FlavorId = new SelectList(_db.Flavors, "ID", "Name");
            return View();
        }
    }
}