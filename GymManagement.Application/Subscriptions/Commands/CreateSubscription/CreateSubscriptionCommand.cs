using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommand : IRequest<ErrorOr<Guid>>
    {
        public CreateSubscriptionCommand(Guid adminId, string subscriptionType)
        {
            AdminId = adminId;
            SubscriptionType = subscriptionType;
        }

        public Guid AdminId { get; }
        public string SubscriptionType { get; }
    }
}
