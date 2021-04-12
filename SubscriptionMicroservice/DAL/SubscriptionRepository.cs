using Newtonsoft.Json;
using SubscriptionMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SubscriptionMicroservice.DAL
{
    public class SubscriptionRepository : ISubscriptionRepository
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

        private async Task<Boolean> DrugAvailable(SubscriptionDetails subscription)
        {
            Drug drug = new Drug();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:7001/api/Drugs/GetDrugByName/" + subscription.DrugName))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    drug = JsonConvert.DeserializeObject<Drug>(apiResponse);
                }
            }
            return (drug.LocQty.ContainsKey(subscription.Location)) && (subscription.Quantity <= drug.LocQty[subscription.Location]);
        }

        public dynamic GetSubscriptionByID(int Sub_id)
        {
            var item = subscriptionList.Where(x => x.SubscriptionID == Sub_id).FirstOrDefault();
            if (item == null)
                return null;
            return item;
        }

        public IEnumerable<SubscriptionDetails> ViewSubscriptions()
        {
            return subscriptionList;
        }

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
        public string RemoveSubscription(int sub_id) 
        {
            if (CheckPaymentStatus(sub_id).Result)
            {
                var sub = subscriptionList.Where(s => s.SubscriptionID == sub_id).FirstOrDefault();
                if(sub != null)
                    subscriptionList.Remove(sub);
                return "Unsubscribed successfully";
            }
            return "Sorry! Clear your dues to unsubscribe";
        }
    }
}
