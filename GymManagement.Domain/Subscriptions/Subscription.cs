using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Domain.Subscriptions
{
    public class Subscription
    {

        private readonly Guid _adminId;

        private Subscription()
        {
        }

        public Subscription(Guid adminId, SubscriptionType type, Guid? id = null)
        {
            _adminId = adminId;
            Id = id ?? Guid.NewGuid();
            Type = type;

        }

        public  Guid Id { get; private set; }
        public SubscriptionType Type { get; private set; }
    }
}
