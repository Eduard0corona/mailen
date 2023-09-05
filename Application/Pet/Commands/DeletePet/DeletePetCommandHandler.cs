using Application.Repositories;
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
        protected IPetRepository _petRepository;
        public DeletePetCommandHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public async Task Handle(DeletePetCommand request, CancellationToken cancellationToken)
        {
            var pet = await _petRepository.GetByIdAsync(request.Id);

            if (pet != null)
            {
                await _petRepository.DeleteAsync(request.Id);
            }
        }
    }
}
