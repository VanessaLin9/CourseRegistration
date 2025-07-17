using CourseRegistration.Interfaces;
using CourseRegistration.Services;

var builder = WebApplication.CreateBuilder(args);

var db_connection = builder.Configuration.GetConnectionString("DefaultConnection");
var password = Environment.GetEnvironmentVariable("MSSQL_SA_PASSWORD");
var final_connection = db_connection!.Replace("__FROM_ENV__", password);
builder.Configuration["ConnectionStrings:DefaultConnection"] = final_connection;


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.WebHost.UseUrls("http://localhost:5000", "https://localhost:5001");

builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();
