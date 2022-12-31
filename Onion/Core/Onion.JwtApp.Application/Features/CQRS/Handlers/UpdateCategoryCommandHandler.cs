using MediatR;
using Onion.JwtApp.Application.Features.CQRS.Commands;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest>
    {
        private readonly IRepository<Category> repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            // 1- entity entry state => modified
            // 2 
            //  Update() ? 

            // connected entity
            // disconnected entity

            // CONNECTED
            var updatedEntity = await this.repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.Definition = request.Definition; // 1- modified
                await this.repository.SaveChangesAsync();
            }


            //DISCONNECTED
            //var updatedCategory = new Category()
            //{
            //    Definition = request.Definition,
            //    Id = request.Id
            //};

            // addorupdate

            //await this.repository.UpdateAsync(updatedCategory);

            return Unit.Value;
        }
    }
}
