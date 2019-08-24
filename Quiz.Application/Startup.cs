using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Quiz.Repository;
using Quiz.Repository.Interfaces;
using Quiz.Services;
using Quiz.Services.Interfaces;
using Quiz.Application.Middlewares;

namespace Quiz.Application
{
    public class Startup
    {
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddMvc( ).SetCompatibilityVersion( CompatibilityVersion.Version_2_2 );
            DependencyInjections(services);
        }

        private void DependencyInjections(IServiceCollection services)
        {

            services.BuildServiceProvider( );

            // Adiciona os middlewares
            services.AddDependencyInjection( );
            services.AddLoggerMiddleware( Configuration );
            services.AddSwaggerMiddleware( );
        }

        public void Configure( IApplicationBuilder app, IHostingEnvironment env )
        {
            if ( env.IsDevelopment( ) )
            {
                app.UseDeveloperExceptionPage( );
            }

            app.UseMvc( );
            app.UseSwaggerMiddleware( );
        }
    }
}
