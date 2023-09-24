using FirstCRUDAPI.Context;
using FirstCRUDAPI.Models;
using FirstCRUDAPI.Services.Classes;
using FirstCRUDAPI.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace FirstCRUDAPI
{
    public class Program
    {

        private static readonly UserServices _userServices;
        private static readonly OrderServices _orderServices;
        public static void Main(string[] args)
        {
            #region
            //var builder = WebApplication.CreateBuilder();
            //var app = builder.Build();

            //builder.Services.AddDbContext<SofiaDbContext>();
            //builder.Services.AddControllers();

            //builder.Services.AddScoped<IUserServices, UserServices>();
            //builder.Services.AddScoped<IOrderServices, OrderServices>();

            //builder.Services.AddControllersWithViews();

            //app.MapGet("/", () => Since(app.Configuration));

            //app.Run();
            #endregion

            //var builder = WebApplication.CreateBuilder();
            //var app = builder.Build();

            //// Регистрируем DbContext и настраиваем его


            //builder.Services.AddControllers();

            //builder.Services.AddScoped<IUserServices, UserServices>();
            //builder.Services.AddScoped<IOrderServices, OrderServices>();

            //app.MapGet("/", () => Start());

            //app.Run();


            //var builder = WebApplication.CreateBuilder();
            //var app = builder.Build();

            //builder.Services.AddDbContext<SofiaDbContext>();
            //builder.Services.AddControllers(); // Замените AddControllers на AddControllersCore, если это необходимо.

            //builder.Services.AddScoped<IUserServices, UserServices>();
            //builder.Services.AddScoped<IOrderServices, OrderServices>();

            //app.MapGet("/", () => Since(app.Configuration));
            //app.Run();
            CreateHostBuilder(args).Build().Run();


        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartUp>();
                });

        //public static string Since(IConfiguration configuration)
        //{
        //    Controller controller = new(configuration);
        //    return controller.Start();

        //}
        

        
    }
}