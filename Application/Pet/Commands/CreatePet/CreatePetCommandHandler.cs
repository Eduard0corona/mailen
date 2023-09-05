using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Pet.Commands.CreatePet
{
    public class CreatePetCommandHandler : IRequestHandler<CreatePetCommand, int>
    {
        public CreatePetCommandHandler()
        {
            //TODO: Inyectar contexto
        }
        public Task<int> Handle(CreatePetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
