using FirstCRUDAPI.Context;
using FirstCRUDAPI.Services.Classes;
using FirstCRUDAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FirstCRUDAPI
{
    public class StartUp
    {
        public StartUp(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            // Регистрация DbContext и настройка строки подключения
            services.AddDbContext<SofiaDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            });

            // Регистрация ваших служб
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IOrderServices, OrderServices>();
            
            // Регистрация контроллеров
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Настройка маршрутизации контроллеров
            });
        }
    }
}
