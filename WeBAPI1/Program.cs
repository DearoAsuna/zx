namespace WeBAPI1
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
            builder.Services.AddScoped<Calculator>();
            builder.Services.AddScoped<Time>();
            builder.Services.AddCors(b =>
            {
                b.AddDefaultPolicy(b =>
                {
                    b.WithOrigins(new string[]
                    {
                        "http://localhost:5173"
                    }).AllowAnyMethod().AllowAnyHeader().AllowCredentials();
                });
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
            app.UseResponseCaching();//启用服务器响应缓存
            app.UseCors();
            app.MapControllers();

            app.Run();
        }
    }
}