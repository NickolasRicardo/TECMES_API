using TECMESAPI.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace TECMESAPI.Application.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(ConfigurationMapping));
        }
    }
}
