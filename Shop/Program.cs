using Microsoft.AspNetCore;
using Shop;
using Shop.Data.Interfaces;
using Shop.Data.Mocks;

// ConfigureServices
//var builder = WebApplication.CreateBuilder(args).UseStartup<Startup>();

////builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
////builder.Services.AddTransient<IAllCars, MockCars>();
////builder.Services.AddTransient<ICarsCategory, MockCategory>();

////Configure
//var app = builder.Build();
//app.UseDeveloperExceptionPage();
//app.UseStatusCodePages();
//app.UseStaticFiles();
//app.UseMvcWithDefaultRoute();
//app.Run();

namespace Shop 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }
    }
}