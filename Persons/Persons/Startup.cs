using Persons.Data;

namespace Persons
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
            // connect vue app - middleware  
            services.AddSpaStaticFiles(options => options.RootPath = "client-app/dist");

            services.AddDbContext<PersonsContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("PersonsContext")));

            services.AddDbContext<PersonsContext>(options => options.UseSqlServer("Data Source=Persons.dbo"));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.  
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.  
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllers();
            });

            // use middleware and launch server for Vue  
            app.UseSpaStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "client-app";
                if (env.IsDevelopment())
                {

                    spa.UseVueDevelopmentServer();
                }
            });
        }
    }
}
