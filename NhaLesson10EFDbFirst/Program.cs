using Microsoft.EntityFrameworkCore;
using NhaLesson10EFDbFirst.Models;

namespace NhaLesson10EFDbFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Cau hinh ket noi co so du lieu
            var nhaConnectionString = builder.Configuration.GetConnectionString("NhaLesson10EfConnectionString")
                ?? builder.Configuration.GetConnectionString("NhaLesson10EFDbContext");

            builder.Services.AddDbContext<NhaLesson10EfdbContext>(options =>
                options.UseSqlServer(nhaConnectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

