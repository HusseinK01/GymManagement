using GymManagement.Application.Subscriptions.Commands.CreateSubscription;
using GymManagement.Contracts.Subscriptions;
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

            var subscriptionId = await mediator.Send(command);

            var response = new CreateSubscriptionResponse(subscriptionId, request.SubscriptionType);
            return Ok(response);

        }
    }
}
