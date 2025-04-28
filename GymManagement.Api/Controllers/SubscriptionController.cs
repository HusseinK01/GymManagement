using ErrorOr;
using GymManagement.Application.Subscriptions.Commands.CreateSubscription;
using GymManagement.Application.Subscriptions.Queries.GetSubscription;
using GymManagement.Contracts.Subscriptions;
using GymManagement.Domain.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISender mediator;

        public SubscriptionController(ISender mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubscruption (CreateSubscruptionRequest request)
        {
            var command = new CreateSubscriptionCommand(request.AdminId, request.SubscriptionType.ToString());

            ErrorOr.ErrorOr<Subscription> createSubscriptionResult = await mediator.Send(command);


            return createSubscriptionResult.MatchFirst(

                subscription => Ok(new CreateSubscriptionResponse(subscription.Id, request.SubscriptionType)),
                error => Problem()
                );

        }



        [HttpGet("{subscriptionId:guid}")]
        public async Task<IActionResult> GetSubscriptionById(Guid subscriptionId)
        {
            var query = new GetSubscriptionQuery(subscriptionId);

            ErrorOr.ErrorOr<Subscription> getSubscriptionResult = await mediator.Send(query);
            return getSubscriptionResult.MatchFirst(
                subscription => Ok(new GetSubscriptionRespone() { Id = subscription.Id, Type = subscription.Type }),
                error => Problem()
                );
        }
    }
}
