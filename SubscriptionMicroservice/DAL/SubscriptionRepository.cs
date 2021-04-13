using Newtonsoft.Json;
using SubscriptionMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SubscriptionMicroservice.DAL
{
    public class SubscriptionRepository : ISubscriptionRepository, IDisposable
    {

        //subscription list
        public static List<SubscriptionDetails> subscriptionList = new List<SubscriptionDetails>()
        {
            new SubscriptionDetails
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
            new SubscriptionDetails
            {
                SubscriptionID = 102,
                MemberID = 2,
                DrugName = "Ativan",
                Location = "Bangalore",
                Quantity = 20,
                RefillOccurance = "Weekly",
                NoOfRefills = 10,
                InsuranceId = "LIC264156"
            },
            new SubscriptionDetails
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

        /// <summary>This method returns the subscription details based on the id</summary>
        /// <param name="sub_id">the id of the subscription which is to be searched for</param>
        public dynamic GetSubscriptionByID(int sub_id)
        {
            var item = subscriptionList.Where(x => x.SubscriptionID == sub_id).FirstOrDefault();
            return item;
        }

        /// <summary>This method returns all the existing subscriptions</summary>
        public IEnumerable<SubscriptionDetails> ViewSubscriptions()
        {
            return subscriptionList;
        }

        /// <summary>This method adds a new subscription to the subscription list</summary>
        /// <param name="sub_id">an instance of the SubscriptionDetails class which is to be added to the subscription list</param>
        public string AddSubscription(SubscriptionDetails subscription)
        {
            if (DrugAvailable(subscription).Result)
            {
                subscription.SubscriptionID = 100 + subscriptionList.Count;
                subscriptionList.Add(subscription);
                return "Subscription Added Successfully";
            }
            return "Sorry, the requested drug is not available at this location";
        }


        /// <summary>This method checks whether the payment dues are cleared for a particular subscription.
        ///This method also calls the api of RefillMicroservice to get the refill details</summary>
        /// <param name="subscription">The id of the subscription whose payment status is to be verified.</param>
        private async Task<Boolean> CheckPaymentStatus(int sub_id)
        {
            RefillDetails refill = new RefillDetails();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:7002/api/Refill/RefillStatus/" + sub_id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    refill = JsonConvert.DeserializeObject<RefillDetails>(apiResponse);
                }
            }
            return String.Compare(refill.Status, "clear", StringComparison.OrdinalIgnoreCase) == 0;
        }

        /// <summary>This method removes an existing subscription from the subscription list</summary>
        /// <param name="sub_id">an instance of the SubscriptionDetails class which is to be removed from the subscription list</param>
        public string RemoveSubscription(int sub_id)
        {
            if (CheckPaymentStatus(sub_id).Result)
            {
                var sub = subscriptionList.Where(s => s.SubscriptionID == sub_id).FirstOrDefault();
                if (sub != null)
                    subscriptionList.Remove(sub);
                return "Unsubscribed successfully";
            }
            return "Sorry! Clear your dues to unsubscribe";
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
