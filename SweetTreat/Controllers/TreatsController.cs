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
        public TreatsController( SweetTreatContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Treats.ToList());
        }
    }
}