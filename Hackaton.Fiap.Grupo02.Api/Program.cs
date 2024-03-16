using Hackaton.Fiap.Grupo02.IOCWrapper;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.OpenApi.Models;
using MySqlConnector;
using Serilog;
using Serilog.Sinks.MariaDB;
using Serilog.Sinks.MariaDB.Extensions;
using System.Reflection;
using Hackaton.Fiap.Grupo02.Api.Controllers;

var builder = WebApplication.CreateBuilder(args);


Startup.Bootstrap(builder.Services);


builder.Services.AddCors(options =>
{

    options.AddPolicy("default", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Hackaton Fiap - Grupo 02",
        Description = "API do sistema",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }

    });
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";


    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});


//builder.Host.UseSerilog((context, configuration) =>
//{
//    configuration
//        .WriteTo.Console()
//        .WriteTo.MariaDB(
//            context.Configuration["ConnectionStrings:DefaultConnection"],
//            tableName: "Logs",
//            autoCreateTable: true,
//            useBulkInsert: false,
//            options: new MariaDBSinkOptions()
//            );

//});

var app = builder.Build();
app.UseCors("default");
//app.UseAuthentication();
//app.UseAuthorization();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Configuracoes

//Fim Configuracoes


app.MapMethods(VideoImageGetAll.Template, VideoImageGetAll.Methods, VideoImageGetAll.Handle);


//app.UseExceptionHandler("/error");
//app.Map("/error", (HttpContext http) =>
//{

//    var error = http.Features?.Get<IExceptionHandlerFeature>()?.Error;

//    if (error != null)
//    {
//        if (error is MySqlException)
//            return Results.Problem(title: "Database out", statusCode: 500);
//        else if (error is BadHttpRequestException)
//            return Results.Problem(title: "Error to convert data to other type. See all the information sent", statusCode: 500);
//    }

//    return Results.Problem(title: "An error ocurred", statusCode: 500);
//});



app.Run();

