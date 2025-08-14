using Microsoft.EntityFrameworkCore;
using MyFirstASP_Application.Models;
using MyFirstASP_Application.Services.DateService;
using MyFirstASP_Application.Services.ExpenseService;
using MyFirstASP_Application.Services.ResponsibilityService;

namespace MyFirstASP_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ExpensesDbContext>(options => 
                options.UseInMemoryDatabase("ExpensesDb")
            );
            builder.Services.AddDbContext<ResponsibilitiesDbContext>(options =>
                options.UseInMemoryDatabase("ResponsibilitiesDb")
            );
            builder.Services.AddDbContext<DatesDbContext>(options =>
                options.UseInMemoryDatabase("DatesDb")
            );
            builder.Services.AddScoped<IDateService, DateSrvc>();
            builder.Services.AddScoped<IExpenseService, ExpenseSrvc>();
            builder.Services.AddScoped<IResponsibilityService, ResponsibilitySrvc>();


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
