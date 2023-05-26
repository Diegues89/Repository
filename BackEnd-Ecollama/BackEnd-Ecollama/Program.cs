using BackEnd_Ecollama.DataBase;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Configuration
    //.AddJsonFile("Config/appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"Config/connectionStrings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"Config/appsettings.json", optional: true, reloadOnChange: true);


builder.Services.AddDbContext<DBContextEcollama>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStringsEcollama")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:44329/api/", "http://localhost:8080")
                                                    .AllowAnyHeader()
                                                    .AllowAnyMethod();
                      });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.UseCors(MyAllowSpecificOrigins);

app.Run();
