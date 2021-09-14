using DAL.WebApi.DbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace OpenGlass_WebApi
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
            services.AddDbContext<OpenGlassDbContext>(dbOption => dbOption.UseSqlServer(Configuration.GetConnectionString("default"),
                dbMigrationOption => dbMigrationOption.MigrationsAssembly("DAL")));

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                // Configure identity options here.
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            }
            ).AddEntityFrameworkStores<OpenGlassDbContext>();

            services.AddControllers();
            
            services.AddSwaggerGen(action =>
            {
                action.SwaggerDoc("v1", new OpenApiInfo { Title = "OpenGlass-WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(action =>
                {
                    action.SwaggerEndpoint("/swagger/v1/swagger.json", "OpenGlass-WebApi");
                });
            }

            app.UseRouting();
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
