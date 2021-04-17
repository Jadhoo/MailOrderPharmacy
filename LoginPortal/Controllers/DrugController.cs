using LoginPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPortal.Controllers
{
    public class DrugController : Controller
    {
        // GET: DrugController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DrugController/Details/5
        public ActionResult SearchDrug(Drug drug)
        {
            DrugDetails drugDetails;
            //if the user is searching by id use this....if required convert drug.SearchString to int...call the api for getting drug details using id
            if(drug.SearchBy == "id")
            {
                drugDetails = new DrugDetails()
                {
                    DrugId = 1,
                    Name = "Paracip-500",
                    Manufacturer = "Mankind",
                    ManufacturedDate = new DateTime(2020, 09, 21),
                    ExpiryDate = new DateTime(2021, 09, 20),
                    UnitCost = 5.00,
                    LocQty = new Dictionary<string, int>()
                    {
                        {"Pune",50 },
                        {"Bangalore",80 },
                        {"Chennai",60 }
                    }
                };
            }
            ///call api to get drug details by drug name
            else
            {
                drugDetails = new DrugDetails()
                {
                    DrugId = 2,
                    Name = "Paracip-500",
                    Manufacturer = "Mankind",
                    ManufacturedDate = new DateTime(2020, 09, 21),
                    ExpiryDate = new DateTime(2021, 09, 20),
                    UnitCost = 5.00,
                    LocQty = new Dictionary<string, int>()
                    {
                        {"Pune",50 },
                        {"Bangalore",80 },
                        {"Chennai",60 }
                    }
                };
            }
            
            return View(drugDetails);
        }



        public ActionResult GetDrugQuantity(Drug drug)
        {
            int quantiy = 0;
            //quantiy = call api to get quantiy using loc and name
            ViewBag.Message = $"Quantity available at {drug.Location} is {quantiy}";
            return View("Index");
        }

        // GET: DrugController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrugController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DrugController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DrugController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DrugController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DrugController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}