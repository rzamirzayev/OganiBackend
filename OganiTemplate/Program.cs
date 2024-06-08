using Microsoft.EntityFrameworkCore;
using OganiTemplate.Models.Contexts;

namespace OganiTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"), opt =>
                {
                    opt.MigrationsHistoryTable("MigrationsHistory");
                });
            });
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute("default", pattern: "{controller=home}/{action=index}/{id?}");
            app.Run();
        }
    }
}