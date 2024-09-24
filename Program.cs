using Booking.customValidate;
using Booking.Models;
using Booking.Models.Data;
using Booking.Models.Repo;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Booking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
                
            });
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped(typeof(ICityRepo), typeof(CityRepo));
            builder.Services.AddScoped(typeof(IHotelRepo), typeof(HotelRepo));
            //builder.Services.AddScoped(typeof(IEmailConfirmationSender), typeof(EmailConfirmationSender));
            //builder.Services.AddScoped(typeof(IEmailSender), typeof(EmailSender));

            builder.Services.AddIdentity<User, IdentityRole>(action =>
                {

                    action.User.RequireUniqueEmail = true;
                    action.SignIn.RequireConfirmedEmail = true;

                }

            ).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            builder.Services.Configure<IdentityOptions>(options =>
                    {
                        options.SignIn.RequireConfirmedEmail = true;
                        options.User.RequireUniqueEmail = true;
                    }       
            );

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

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}