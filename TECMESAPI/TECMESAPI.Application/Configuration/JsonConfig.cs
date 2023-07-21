using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

namespace TECMESAPI.Application.Configuration
{
    public static class JsonConfig
    {
        public static void AddJsonConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
            .AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                x.JsonSerializerOptions.IgnoreNullValues = true;
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
        }
    }
}
