using ApplicationCore.Interfaces;
using ApplicationCore.Mapping;
using ApplicationCore.Services;
using AutoMapper;
using GoCafe.Interfaces;
using GoCafe.Services;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GoCafe
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

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //account
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAccountIndexVmService, AccountIndexVmService>();
            //product
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductIndexVmService, ProductIndexVmService>();
            //category
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryIndexVmService, CategoryIndexVmService>();
            //bill
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IBillService,BillService>();
            services.AddScoped<IBillIndexVmService, BillIndexVmService>();
            //infobill
            services.AddScoped<IInfoBillRepository, InfoBillRepository>();
            services.AddScoped<IInfoBillService,InfoBillService>();
            services.AddScoped<IInfoBillIndexVmService, InfoBillIndexVmService>();
            
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddSession();
            services.AddRazorPages();
            services.AddDbContext<GoCafeContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("GoCafeConnection")));
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
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
