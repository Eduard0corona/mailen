using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Pet.Commands.DeletePet
{
    public class DeletePetCommandHandler : IRequestHandler<DeletePetCommand>
    {
        public Task Handle(DeletePetCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
