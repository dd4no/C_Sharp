using System;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View();
        }


        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = 50;
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (age <= 18)
                {
                    insuree.Quote += 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    insuree.Quote += 50;
                }
                else if (age > 25)
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
                insuree.Quote += 10 * insuree.SpeedingTickets;
                if (insuree.DUI)
                {
                    insuree.Quote = Decimal.Multiply(insuree.Quote, 1.25m);
                }
                if (insuree.CoverageType)
                {
                    insuree.Quote = Decimal.Multiply(insuree.Quote, 1.5m);
                }
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Quote", insuree);
            }

            return View(insuree);
        }



        public ActionResult Quote(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            return View(insuree);
        }
    }
}
