using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


 void main(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);


    builder.Services.AddEndpointsApiExplorer(); 
    builder.Services.AddSwaggerGen(); 


    var app = builder.Build();


    app.UseSwagger(); 
    app.UseSwaggerUI(); 
}

app.Run();