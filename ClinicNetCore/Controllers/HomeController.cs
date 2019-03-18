using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ClinicNetCore.Models;

namespace ClinicNetCore.Controllers
{
    public class HomeController : Controller
    {
        ClinicContext db;
        public HomeController(ClinicContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Patients.ToList());
        }

        [HttpGet]
        public IActionResult FillVisit(int id)
        {
            ViewBag.PatientId = id;
            return View();
        }
        [HttpPost]
        public string FillVisit(Visit visit)
        {
          //  visit.VisitedAt = System.DateTime.Now;
            db.Visits.Add(visit);
            //db.SaveChanges();
            //db.Visits.ToList();
            return "Thank you for filling!";
        }

    }
}
