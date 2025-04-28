using GymManagement.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Common
{
    public interface ISubscriptionRepository
    {
        public Task AddSubscriptionAsync(Subscription subscription);

        public Task<Subscription?> GetSubscriptionAsync(Guid subscriptionId);
    }
}
