using Application.Repositories;
using MediatR;

namespace Application.Pet.Queries.GetPets
{
    public class GetPetsQueryHandler : IRequestHandler<GetPetsQuery, IEnumerable<Domain.Entities.Pet>>
    {
        readonly IPetRepository _petRepository;
        public GetPetsQueryHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<IEnumerable<Domain.Entities.Pet>> Handle(GetPetsQuery request, CancellationToken cancellationToken)
        {
            return await _petRepository.GetAllAsync();
        }
    }
}
