using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;
using WeddingStoreAPI.Services;

namespace WeddingStoreAPI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public IConfigurationRoot Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddMvc();
            //services.AddSingleton<IVatLieuRepository, MockVatLieuRepository>();
            //services.AddScoped<IVatLieuRepository, Ahihi>();
            services.AddSingleton(Configuration);
            services.AddScoped<IDataService<VatLieuModel>, VatLieuService>();
            services.AddScoped<IDataService<SanPhamModel>, SanPhamService>();
            services.AddScoped<IDataService<PhatSinhModel>, PhatSinhService>();
            services.AddScoped<IDataService<PhanCongModel>, PhanCongService>();
            services.AddScoped<IDataService<NhanVienModel>, NhanVienService>();
            services.AddScoped<IDataService<NhaCungCapModel>, NhaCungCapService>();
            services.AddScoped<IDataService<LoaiDichVuModel>, LoaiDichVuService>();
            services.AddScoped<IDataService<KhachHangModel>, KhachHangService>();
            services.AddScoped<IDataService<HoaDonModel>, HoaDonService>();
            services.AddScoped<IDataService<DonGiaNhapHangModel>, DonGiaNhapHangService>();
            services.AddScoped<IDataService<DichVuModel>, DichVuService>();
            services.AddScoped<IDataService<ChiTietSanPhamModel>, ChiTietSanPhamService>();
            services.AddScoped<IDataService<ChiTietHoaDonModel>, ChiTietHoaDonService>();
            services.AddScoped<IDataService<ChiTietDonGiaNhapHangModel>, ChiTietDonGiaNhapHangService>();
            services.AddScoped<IDataService<TaiKhoanModel>, TaiKhoanService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<WeddingStoreContext>(options
                => options.UseSqlServer(Configuration.GetConnectionString("WeddingStoreConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.UseMvc(route =>
            {
                route.MapRoute("default", "{controller=Home}/{action=Index}/{maVL?}");
                //route.MapRoute("default", "{controller}/{action}/{id?}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
