using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetCategoryQueryRequest : IRequest<CategoryListDto?>
    {
        public int Id { get; set; }

        public GetCategoryQueryRequest(int id)
        {
            Id = id;
        }
    }
}
