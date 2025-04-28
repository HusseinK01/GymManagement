using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Domain.Subscriptions
{
    public class Subscription
    {
        public required Guid Id { get; set; }
        public required string Type { get; set; }
    }
}
