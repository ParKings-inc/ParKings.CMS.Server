using Microsoft.EntityFrameworkCore;
using ParKings.CMS.Server.Databases;
using ParKings.CMS.Server.Middleware;

const string ParkingOrigins = "_ParkingOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ParKingsContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL_ParKingsDB")));
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

builder.Services.AddTransient<GoogleAuthenticationMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.WithOrigins("http://localhost:3000")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
);

app.UseGoogleAuthenticationMiddleware();

app.UseHttpsRedirection();

app.UseCors(ParkingOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
