using LoginPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPortal.Controllers
{
    public class SubscriptionController : Controller
    {
        // GET: SubscriptionController
        public ActionResult Index()
        {
            IEnumerable<Subscription> subscriptionList = new List<Subscription>()
        {
            new Subscription
            {
                SubscriptionID = 101,
                MemberID = 1,
                DrugName = "Paracetamol",
                Location = "Mumbai",
                Quantity = 10,
                RefillOccurance = "Weekly",
                NoOfRefills = 5,
                InsuranceId = "LIC204156"
            },
             new Subscription
            {
                SubscriptionID = 103,
                MemberID = 2,
                DrugName = "Adderall",
                Location = "Chennai",
                Quantity = 5,
                RefillOccurance = "Monthly",
                NoOfRefills = 10,
                InsuranceId = "LIC244156"
            }
        };

            return View(subscriptionList);
        }

        // GET: SubscriptionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubscriptionController/Create
        public ActionResult AddSubscription()
        {
            return View();
        }

        // POST: SubscriptionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSubscription(Subscription obj)
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


        // GET: SubscriptionController/Delete/5
        public ActionResult RemoveSubscription(int id)
        {
            return View();
        }

        // POST: SubscriptionController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult RemoveSubscription(int id)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
