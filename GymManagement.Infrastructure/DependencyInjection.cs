using GymManagement.Application.Common;
using GymManagement.Infrastructure.Subscriptions.Persistance;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISubscriptionRepository, SubscriptionsRepository>();
            return serviceCollection;
        }
    }
}
