using ArtavBlog.Business.Base;
using ArtavBlog.Hubs;
using ArtavBlog.Models.Account;
using ArtavBlog.Models.Base;
using ArtavBlog.Models.Blog;
using ArtavBlog.Models.Messaging.Sms;
using ArtavBlog.Repository.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ArtavBlog
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            Identity();
            LocalDependencyInjection();
            void Identity()
            {
                services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                    {
                        options.Password.RequiredLength = 6;
                        options.User.RequireUniqueEmail = true;
                        options.Password.RequireLowercase = false;
                        options.Password.RequireUppercase = false;
                        options.Password.RequireNonAlphanumeric = false;
                    })
                    .AddEntityFrameworkStores<BlogContext>()
                    //   .AddDefaultUI()
                    .AddDefaultTokenProviders();
            }
            void LocalDependencyInjection()
            {
                services.AddSignalR();
                services.AddTransient<ISqlBaseRepository<Post>, BaseSqlBusiness<Post>>();
                services.AddTransient<ISqlBaseRepository<PhoneNumber>, BaseSqlBusiness<PhoneNumber>>();
                //services.AddDbContext<BlogContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BlogConnection")));
                services.AddDbContextPool<BlogContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BlogConnection")));
            }
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
