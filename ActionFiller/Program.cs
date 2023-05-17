using EFCore11;
using FillterWebAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ActionFiller
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<MyDbContext>
            (a =>
            {
                a.UseSqlServer("Server=.;" +
                               "Data Source=LAPTOP-5AQ8PCDO\\SQLEXPRESS;" +
                               " Database = WebAPIdemo2;Encrypt=True;Trusted_Connection=True;" +
                               "TrustServerCertificate=True;");
            });

            builder.Services.Configure<MvcOptions>
            (a =>
            {
                a.Filters.Add<MyExcpetionFiller>();
                a.Filters.Add<MyActionFiller>();
                a.Filters.Add<MyActionFillter>();
                a.Filters.Add<TransactionScopeFiller>();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}