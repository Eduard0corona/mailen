using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Pet.Commands.UpdatePet
{
    public class UpdatePetCommandHandler : IRequestHandler<UpdatePetCommand>
    {
        public Task Handle(UpdatePetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
