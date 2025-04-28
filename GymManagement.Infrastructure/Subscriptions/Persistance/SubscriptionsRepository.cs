using GymManagement.Application.Common;
using GymManagement.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.Subscriptions.Persistance
{
    class SubscriptionsRepository : ISubscriptionRepository
    {
        private readonly static List<Subscription> subscriptions = new();


        public Task AddSubscriptionAsync(Subscription subscription)
        {
            subscriptions.Add(subscription);
            return Task.CompletedTask;
        }

        public Task<Subscription?> GetSubscriptionAsync(Guid subscriptionId)
        {

            Subscription subscription = subscriptions.FirstOrDefault(s => s.Id == subscriptionId);
            return Task.FromResult(subscription);
            
        }
    }
}
