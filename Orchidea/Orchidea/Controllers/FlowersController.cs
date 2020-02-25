using MediatR;
using Microsoft.AspNetCore.Mvc;
using Orchidea.Commands.Flowers;
using Orchidea.Queries.Flowers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Orchidea.Controllers
{
    public class FlowersController : Controller
    {
        private readonly IMediator _mediator;

        public FlowersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("flowers")]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var flowers = await _mediator.Send(new GetFlowersQuery(), cancellationToken);

            return Ok(flowers);
        }

        [HttpDelete]
        [Route("flowers/{flowerId}")]
        public async Task<IActionResult> Delete([FromRoute] Guid flowerId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var flowers = await _mediator.Send(new DeleteFlowerCommand { Id = flowerId }, cancellationToken);

            return Ok(flowers);
        }
    }
}