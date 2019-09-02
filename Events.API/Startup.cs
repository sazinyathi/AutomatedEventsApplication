using Events.Intefarces.Services;
using Events.Interfaces.Repositories;
using Events.Interfaces.Services;
using Events.Notifications;
using Events.Repositories;
using Events.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Events.API
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<EventsDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AutomatedEventsApplication", Version = "v1" });
            });

            #region Business Logic Injections
            services.AddTransient<IEventsServices, EventsServices>();
        #endregion

            #region DAL Injections
            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<INotificationService, EmailNotificationService>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AutomatedEventsApplication");
            });
            app.UseMvc();
         
        }
    }
}
