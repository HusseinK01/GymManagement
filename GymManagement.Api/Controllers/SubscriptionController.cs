using ErrorOr;
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

            ErrorOr.ErrorOr<Guid> createSubscriptionResult = await mediator.Send(command);


            return createSubscriptionResult.MatchFirst(

                guid => Ok(new CreateSubscriptionResponse(guid, request.SubscriptionType)),
                error => Problem()
                );

        }
    }
}
