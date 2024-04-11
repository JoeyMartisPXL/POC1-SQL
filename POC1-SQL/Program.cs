
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace POC1_SQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //ConfigurationManager configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();



            builder.Services.AddDbContext<ModelContext>(options =>
            {
                // Retrieve the Oracle connection string from configuration
                string oracleConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=ORCL)));Persist Security Info=True;User Id=IVBUSER;Password=IVB;";

                // Configure the DbContext to use Oracle database
                options.UseOracle(oracleConnectionString);
            });
            

            var connection = String.Empty;
            if (builder.Environment.IsDevelopment())
            {
                builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
                connection = builder.Configuration.GetConnectionString("ORACLE_CONNECTIONSTRING");
            }
            else
            {
                connection = Environment.GetEnvironmentVariable("AZURE_SQL_CONNECTIONSTRING");
            }

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.MapGet("/Varken", (ModelContext context) =>
            {
                return context.Varkens.Take(5).ToList();
            })
            .WithName("GetVarkens")
            .WithOpenApi();

            app.MapGet("/Rund", (ModelContext context) =>
            {
                return context.Runds.Take(5).ToList();
            })
            .WithName("GetRunderen")
            .WithOpenApi();


            app.MapGet("/Metingrund", (ModelContext context) =>
            {
                return context.Metingrunds.Take(5).ToList();
            })
            .WithName("GetMetingrund")
            .WithOpenApi();

            app.MapGet("/Metingvarken", (ModelContext context) =>
            {
                return context.Metingvarkens.Take(5).ToList();
            })
            .WithName("GetMetingvarken")
            .WithOpenApi();



            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.Run();
        }
    }
}
