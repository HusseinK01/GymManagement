using GymManagement.Application.Common;
using GymManagement.Infrastructure.Common.Persistance;
using GymManagement.Infrastructure.Subscriptions.Persistance;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
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
            serviceCollection.AddDbContext<GymManagementDbContext>(options => options.UseSqlite("Data Source = GymManagement.db"));
            serviceCollection.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<GymManagementDbContext>());
            serviceCollection.AddScoped<ISubscriptionRepository, SubscriptionsRepository>();
            return serviceCollection;
        }
    }
}
