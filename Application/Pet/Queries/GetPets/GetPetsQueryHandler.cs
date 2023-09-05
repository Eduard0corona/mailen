using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Pet.Queries.GetPets
{
    public class GetPetsQueryHandler : IRequestHandler<GetPetsQuery, PetDto>
    {
        public Task<PetDto> Handle(GetPetsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
