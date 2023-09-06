using Application.Pet.Queries.GetPets;
using Application.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Pet.Queries.GetPetById
{
    public class GetPetByIdHandler : IRequestHandler<GetPetByIdQuery, GetPetByIdDto>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public GetPetByIdHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<GetPetByIdDto> Handle(GetPetByIdQuery request, CancellationToken cancellationToken)
        {
            var pets = await _mediator.Send(new GetPetsQuery());
            var selectedPet = pets.Where(s => s.Id == request.id).FirstOrDefault();
            return _mapper.Map<GetPetByIdDto>(selectedPet);
        }
    }
}
