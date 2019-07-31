using Events.API.Common;
using Events.API.Common.Interface;
using Events.DAL.Interfaces;
using Events.Repositories;
using Events.Services;
using Events.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Events.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<EventsDbContext>();
            services.AddSwaggerDocument();

            #region Business Logic Injections
            services.AddTransient<IEventsServices, EventsServices>();
            services.AddTransient<IRecipientUsers, RecipientUsersBs>();
            services.AddTransient<IHelper, Helper>();
            #endregion

            #region DAL Injections
            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<IRecipientUsersRepository, RecipientUsersRepository>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvc();
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
