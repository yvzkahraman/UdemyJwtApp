using MediatR;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        private readonly IRepository<Product> repository;

        public DeleteProductCommandHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await this.repository.GetByIdAsync(request.Id);
            if (deletedEntity != null)
                await this.repository.RemoveAsyc(deletedEntity);

            return Unit.Value;
        }
    }
}
