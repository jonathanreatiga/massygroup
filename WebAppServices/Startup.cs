using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Domain.Interface;
using Library.Domain.InterfaceInfra;
using Library.Domain.Servicios;
using Library.Infra.Context;
using Library.Infra.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebAppServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));

            services.AddTransient<IPersonaRepositorio, PersonaRepositorio>();
            services.AddTransient<IPersonaService, PersonaService>();

            services.AddTransient<ITipoNovedadRepositorio, TipoNovedadRepositorio >();
            services.AddTransient<ITipoNovedadService, TipoNovedadService>();

            services.AddTransient<INovedadesNominaRepositorio, NovedadesNominaRepositorio>();
            services.AddTransient<INovedadesNominaService, NovedadesNominaService>();

            var connectionString = Configuration["connectionStrings:DbConnectionString"];
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<ApiContext>(
                    options => options.UseSqlServer(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
