using AutoMapper;
using BusinessManagerPOC.BusinessManager;
using BusinessManagerPOC.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessManagerPOC
{
    public static class BusinessServiceExtension
    {
        public static IServiceCollection ConfigureBusinessServiceExtension(this IServiceCollection service)
        {
            var autoMapper = new MapperConfiguration(x => x.AddProfile(new DataAutoMapper()));
            IMapper mapper = autoMapper.CreateMapper();
            service.AddSingleton(mapper);

            service.AddScoped<IUserManager, UserManager>();

            return service;
        }
    }
}
