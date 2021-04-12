using SubscriptionMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionMicroservice.DAL
{
    public interface ISubscriptionRepository
    {
        public dynamic GetSubscriptionByID(int Sub_id);
        public IEnumerable<SubscriptionDetails> ViewSubscriptions();
        public string AddSubscription(SubscriptionDetails subscription);
        public string RemoveSubscription(int sub_id);
    }
}
