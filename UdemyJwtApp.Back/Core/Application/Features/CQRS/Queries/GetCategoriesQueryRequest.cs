using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetCategoriesQueryRequest : IRequest<List<CategoryListDto>>
    {
    }
}
