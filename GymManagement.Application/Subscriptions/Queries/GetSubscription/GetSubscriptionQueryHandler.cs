using ErrorOr;
using GymManagement.Application.Common;
using GymManagement.Domain.Subscriptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Subscriptions.Queries.GetSubscription
{
    class GetSubscriptionQueryHandler : IRequestHandler<GetSubscriptionQuery, ErrorOr<Subscription>>
    {
        private readonly ISubscriptionRepository subscriptionRepository;

        public GetSubscriptionQueryHandler(ISubscriptionRepository subscriptionRepository)
        {
            this.subscriptionRepository = subscriptionRepository;
        }

        public async Task<ErrorOr<Subscription>> Handle(GetSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var subscription  = await subscriptionRepository.GetSubscriptionAsync(request.SubscriptionId);

            return subscription is null ?
                Error.NotFound(description: "Subscription not found") :
                subscription ;
        }
    }
}
