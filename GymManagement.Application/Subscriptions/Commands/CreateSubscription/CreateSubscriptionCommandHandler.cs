using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, Guid>
    {
        public Task<Guid> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid());
        }
    }
}
