using LoginPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPortal.Controllers
{
    public class RefillController : Controller
    {
        // GET: RefillController
        public ActionResult Index()
        {
            //call api from refill microservice by passing member id to get the list of refill details


            List<RefillDetails> ls = new List<RefillDetails>()
            {
                new RefillDetails
                {
                    RefillOrderId=1,
                    Subscription_ID =101,
                    Member_ID=1,
                    DrugName="Paracetamol",
                    Location="Mangalore",
                    Quantity=2,
                    NoOfRefills=2,
                    FirstRefillDate=new DateTime(2020,04,04),
                    LastRefillDate=new DateTime(2020,07,04),
                    PrevRefillDate=new DateTime(2020,05,04),
                    NextRefillDate=new DateTime(2020,06,04),
                    RefillOccurnace="Monthly",
                    Status="clear"
                }
            };
            return View(ls);
        }

        // GET: RefillController/Details/5
        public ActionResult RefillDetails(int subId)
        {
            //call api from refill microservice by passing subscription id to get the specific refill details
            return View();
        }

        public ActionResult ViewPendingRefills()
        {
            // call api from refill microservice by passing member id to get the list of refill details
            List<RefillDetails> ls = new List<RefillDetails>()
            {
                new RefillDetails
                {
                    RefillOrderId=1,
                    Subscription_ID =101,
                    Member_ID=1,
                    DrugName="Paracetamol",
                    Location="Mangalore",
                    Quantity=2,
                    NoOfRefills=2,
                    FirstRefillDate=new DateTime(2020,04,04),
                    LastRefillDate=new DateTime(2020,07,04),
                    PrevRefillDate=new DateTime(2020,05,04),
                    NextRefillDate=new DateTime(2020,06,04),
                    RefillOccurnace="Monthly",
                    Status="pending"
                },
                new RefillDetails
                {
                    RefillOrderId=1,
                    Subscription_ID =101,
                    Member_ID=1,
                    DrugName="Paracetamol",
                    Location="Mangalore",
                    Quantity=2,
                    NoOfRefills=2,
                    FirstRefillDate=new DateTime(2020,04,04),
                    LastRefillDate=new DateTime(2020,07,04),
                    PrevRefillDate=new DateTime(2020,05,04),
                    NextRefillDate=new DateTime(2020,06,04),
                    RefillOccurnace="Monthly",
                    Status="clear"
                }
            };
            return View(ls);
        }
    }
}
