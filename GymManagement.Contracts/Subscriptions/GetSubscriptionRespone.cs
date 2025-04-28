using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Contracts.Subscriptions
{
    public class GetSubscriptionRespone
    {

        public required Guid Id {get; init;}
        public required string Type { get; init; }
    }
}
