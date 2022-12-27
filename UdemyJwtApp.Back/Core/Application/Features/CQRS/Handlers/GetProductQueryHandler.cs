using AutoMapper;
using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto?>
    {
        private readonly IRepository<Product> repository;
        private readonly IMapper mapper;
        public GetProductQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ProductListDto?> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<ProductListDto>(data);
        }
    }
}
