using Microsoft.AspNetCore.Mvc;
using MediatR;
using Domain.Entities;
using System.Threading;
using Application.Pet.Queries.GetPets;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Pet>>> Login(LoginUserCommand request, CancellationToken cancellationToken)
        {
             var response = await _mediator.Send(request, cancellationToken);

             if(response.Token)

            return Ok(response);
        }
    }
}
