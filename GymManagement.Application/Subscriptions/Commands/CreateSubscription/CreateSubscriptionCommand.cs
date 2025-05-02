using ErrorOr;
using GymManagement.Domain.Subscriptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommand : IRequest<ErrorOr<Subscription>>
    {
        public CreateSubscriptionCommand(Guid adminId, SubscriptionType subscriptionType)
        {
            AdminId = adminId;
            SubscriptionType = subscriptionType;
        }

        public Guid AdminId { get; }
        public SubscriptionType SubscriptionType { get; }
    }
}
