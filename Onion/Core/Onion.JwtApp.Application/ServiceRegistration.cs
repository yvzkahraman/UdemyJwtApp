using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Onion.JwtApp.Application.Mappings;
using System.Reflection;

namespace Onion.JwtApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(opt =>
            {
                opt.AddProfiles(new List<Profile>
                {
                    new CategoryProfile(),
                    new ProductProfile(),
                    new AppUserProfile()
                });
            });
        }
    }
}
