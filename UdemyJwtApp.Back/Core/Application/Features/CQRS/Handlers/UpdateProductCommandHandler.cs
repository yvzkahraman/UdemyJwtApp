using MediatR;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedProduct = await this.repository.GetByIdAsync(request.Id);
            if (updatedProduct != null)
            {
                updatedProduct.Stock = request.Stock;
                updatedProduct.Price = request.Price;
                updatedProduct.Name = request.Name;
                updatedProduct.CategoryId = request.CategoryId;
                await this.repository.UpdateAsync(updatedProduct);
            }

            return Unit.Value; 
        }
    }
}
