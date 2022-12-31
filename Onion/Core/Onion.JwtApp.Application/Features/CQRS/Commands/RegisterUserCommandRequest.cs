using MediatR;
using Onion.JwtApp.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JwtApp.Application.Features.CQRS.Commands
{
    public class RegisterUserCommandRequest : IRequest<CreatedUserDto?>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
