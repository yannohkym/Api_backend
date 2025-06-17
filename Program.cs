using InsurancePolicies.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace InsurancePolicies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
           
            //builder.Services.Configure<PositionOptions>(
            //  builder.Configuration.GetSection(PositionOptions.Position));

            builder.Services.AddDbContext<AppDbContext>(options =>
                     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
                 // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy
                        .WithOrigins("http://localhost:4200") // Angular dev server
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
            });

           
            var app = builder.Build();  // this piece if code   creates the Host ...
            // now  you might  ask yourself what the host does 
              // 1. it encapsulates  ....  dependacy injections, logging, midlewares and configurations ...
              // types of host in asp dotnet .... minimal host, generic  host, web host.

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
           
            app.UseCors();
            app.UseHttpsRedirection();
            app.UseCors();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllers();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();   
        }
    }
}
