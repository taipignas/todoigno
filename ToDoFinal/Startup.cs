using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ToDoFinal.Data;
using ToDoFinal.Identity;
using Microsoft.AspNetCore.Identity;
using ToDoFinal.Services;
using Microsoft.EntityFrameworkCore;

namespace ToDoFinal.web
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
            services.AddRazorPages();
            services.AddDbContext<ToDoUserContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ToDoFinalConnection")));
            services.AddDbContext<ToDoModelContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ToDoFinalConnection")));

            services.AddDefaultIdentity<ToDoUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ToDoUserContext>();
            services.AddScoped<ManageTasks>();
            services.AddScoped<AdminTasks>();
            services.AddScoped<ManageUsers>();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/account");

            services.AddSession();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
