using GymManagement.Application.Common;
using GymManagement.Domain.Subscriptions;
using GymManagement.Infrastructure.Common.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.Subscriptions.Persistance
{
    class SubscriptionsRepository : ISubscriptionRepository
    {
        private readonly GymManagementDbContext _dbcontext;

        public SubscriptionsRepository(GymManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddSubscriptionAsync(Subscription subscription)
        {
            await _dbcontext.Subscriptions.AddAsync(subscription);
        }

        public async Task<Subscription?> GetSubscriptionAsync(Guid subscriptionId)
        {

           var res = await _dbcontext.Subscriptions.FindAsync(subscriptionId);

            return res;
            
        }
    }
}
