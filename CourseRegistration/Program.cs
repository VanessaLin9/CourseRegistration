var builder = WebApplication.CreateBuilder(args);

var db_connection = builder.Configuration.GetConnectionString("DefaultConnection");
var password = Environment.GetEnvironmentVariable("MSSQL_SA_PASSWORD");
var final_connection = db_connection.Replace("__FROM_ENV__", password);
builder.Configuration["ConnectionStrings:DefaultConnection"] = final_connection;


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

Console.WriteLine("Password = " + Environment.GetEnvironmentVariable("MSSQL_SA_PASSWORD"));


app.Run();
