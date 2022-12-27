using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetProductQueryRequest : IRequest<ProductListDto?>
    {
        public int Id { get; set; }

        public GetProductQueryRequest(int id)
        {
            Id = id;
        }
    }
}
