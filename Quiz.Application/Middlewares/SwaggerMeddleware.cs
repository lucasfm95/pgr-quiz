using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Application.Middlewares
{
    [ExcludeFromCodeCoverage]
    public static class SwaggerMeddleware
    {
        public static void AddSwaggerMiddleware( this IServiceCollection services )
        {
            services.AddSwaggerGen( c =>
            {
                c.SwaggerDoc( "v1",
                    new Info
                    {
                        Title = "Quiz",
                        Version = "v1",
                        Description = "Quiz API"
                    } );

                var appPath =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var xmlDocPath =
                    Path.Combine( appPath, "Quiz.Application.xml" );

                c.IncludeXmlComments( xmlDocPath );
            } );
        }

        public static void UseSwaggerMiddleware( this IApplicationBuilder app )
        {
            app.UseSwagger( );
            app.UseSwaggerUI( c =>
            {
                c.SwaggerEndpoint( "/swagger/v1/swagger.json",
                    "Quiz.Application" );
                c.RoutePrefix = "docs";
            } );
        }
    }
}
