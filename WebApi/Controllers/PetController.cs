using Microsoft.AspNetCore.Mvc;
using MediatR;
using Domain.Entities;
using System.Threading;
using Application.Pet.Queries.GetPets;
using Application.Pet.Queries.GetPetById;
using Application.Pet.Commands.CreatePet;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PetController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<PetController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetAll(CancellationToken cancellationToken)
        {
             var response = await _mediator.Send(new GetPetsQuery(), cancellationToken);
             return Ok(response);
        }

        // GET api/<PetController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetPetByIdDto>> GetPetById(int id, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetPetByIdQuery(id), cancellationToken);
            return Ok(response);
        }

        // POST api/<PetController>
        [HttpPost]
        public async Task<ActionResult<int>> Post(CreatePetCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return Ok(response);
        }

        // PUT api/<PetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
