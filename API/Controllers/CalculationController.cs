using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Features;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ILogger<CalculationController> _logger;
        private readonly IMediator _mediator;
        public CalculationController(ILogger<CalculationController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        /// <summary>
        /// Takes a request for some type of calculation that it handles via mediator. The request can specify what type of calculation it wants done.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("calculate")]
        public async Task<IActionResult> Calculate(CalculateFeature.Command request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
