using GymManagement.Application.Common;
using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.Common.Persistance
{
    class GymManagementDbContext : DbContext, IUnitOfWork
    {
        public GymManagementDbContext(DbContextOptions options) : base(options)
        {
        }

        protected GymManagementDbContext()
        {
        }

        public DbSet<Subscription> Subscriptions { get; set; }

        public async Task CommitChangesAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}
