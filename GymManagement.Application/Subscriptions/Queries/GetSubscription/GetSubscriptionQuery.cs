using ErrorOr;
using GymManagement.Domain.Subscriptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Subscriptions.Queries.GetSubscription
{
    public class GetSubscriptionQuery : IRequest<ErrorOr<Subscription>>
    {
        public GetSubscriptionQuery(Guid subscriptionId)
        {
            SubscriptionId = subscriptionId;
        }

        public Guid SubscriptionId { get; set; }
    }
}
