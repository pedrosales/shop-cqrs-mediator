using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopCqrsMediator.Domain.Commands.Requests;
using ShopCqrsMediator.Domain.Queries.Requests;

namespace ShopCqrsMediator.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Create(
            [FromServices]IMediator mediator,
            [FromBody]CreateCustomerRequest command
        )
        {
            var response = mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetById(
            [FromServices]IMediator mediator,
            [FromQuery]FindCustomerByIdRequest command
        )
        {
            var result = mediator.Send(command);
            return Ok(result);
        }
    }
}