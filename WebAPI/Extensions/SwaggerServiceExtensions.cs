using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(
            this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RentACar", Version = "v1" });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumention(
            this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options
                  .SwaggerEndpoint("/swagger/v1/swagger.json", "RentACar API v1");
            });

            return app;
        }
    }
}