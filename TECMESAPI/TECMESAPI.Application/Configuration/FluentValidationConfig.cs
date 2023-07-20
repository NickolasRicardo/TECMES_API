using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace TECMESAPI.Application.Configuration
{
    public static class FluentValidationConfig
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            // services.AddFluentValidation(x =>
            // {
            //     x.RegisterValidatorsFromAssembly(Assembly.GetAssembly(typeof(BenefDTOValidation)));
            //     x.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
            // });
        }
    }
}
