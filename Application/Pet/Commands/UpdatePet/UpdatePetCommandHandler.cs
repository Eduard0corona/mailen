using Application.Repositories;
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
        protected IPetRepository _petRepository;
        protected readonly IUnitOfWork _unitOfWork;
        public UpdatePetCommandHandler(IPetRepository petRepository, IUnitOfWork unitOfWork)
        {
            _petRepository = petRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(UpdatePetCommand request, CancellationToken cancellationToken)
        {
            var pet = await _petRepository.GetByIdAsync(request.Id);

            if (pet != null)
            {
                pet.Name = request.Name;
                pet.Description = request.Description;
                pet.Lineage = request.Type;
            }

            await _petRepository.UpdateAsync(pet!);
        }
    }
}
