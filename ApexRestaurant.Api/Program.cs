
// using System.Configuration;
// using MySql.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;
// using ApexRestaurant.Api;
// using ApexRestaurant.Repository;
// using ApexRestaurant.Services;



// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.

// builder.Services.AddControllers();
// builder.Services.AddDbContext<RestaurantContext>(opt => opt.UseMySQL("Server=127.0.0.1;Port=3306;Database=ApexRestaurantDB;uid=root;pwd=password;"));

// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();





using System;
using Microsoft.AspNetCore.Hosting;
using Apexrestaurant.Api;
namespace Apexrestaurant.Api
{
    public class Program
    {
         public static void Main(String[] args)
         {
             var host = new WebHostBuilder()
             .UseKestrel()
             .UseStartup<Startup>()
             .Build();
             host.Run();
         }

    //     public static void Main(string[] args)
    // {
    //     CreateHostBuilder(args).Build().Run();
    // }

    // public static IHostBuilder CreateHostBuilder(string[] args) =>
    //     Host.CreateDefaultBuilder(args)
    //         .ConfigureWebHostDefaults(webBuilder =>
    //         {
    //             webBuilder.UseStartup<Startup>();
    //         });
    }
}
