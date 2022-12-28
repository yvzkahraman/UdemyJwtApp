using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
