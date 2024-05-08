using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using vitamedica.log;
using vitamedica.Models;
using vitamedica.Models.ConexionBD;
using vitamedica.Models.ConexionRV;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*var configBuilder = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("/opt/services/VitamedicaConfig.json", optional: false, reloadOnChange: true);*/

var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("vitamedica-config.json");

var config = configBuilder.Build();

builder.Services.AddControllers();

builder.Logging.ClearProviders();


WSVitamedica.AppSettings.TipoApi = config["APiConfig:tipoApi"];

if (WSVitamedica.AppSettings.TipoApi == "QA") {

    builder.Services.AddDbContext<VitamedicaContext>(opt => opt.UseMySQL(config.GetConnectionString("connMySqlQA")));

} else if (WSVitamedica.AppSettings.TipoApi == "Produccion") {

    builder.Services.AddDbContext<VitamedicaContext>(opt => opt.UseMySQL(config.GetConnectionString("connMySqlP")));

} else {

    builder.Services.AddDbContext<VitamedicaContext>(opt => opt.UseMySQL(config.GetConnectionString("connMySqlL")));

}

string logFilePath = config["Logging:filepath"];

StreamWriter logFileWriter = new StreamWriter(logFilePath, append: true);

//Create an ILoggerFactory
ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    //Add console output
    builder.AddConsole(options =>
    {
        options.FormatterName = ConsoleFormatterNames.Simple;
    });

    //Add a custom log provider to write logs to text files
    builder.AddProvider(new CustomFileLoggerProvider(logFileWriter));
});

//Create an ILogger
ILogger<Program> logger = loggerFactory.CreateLogger<Program>();
VitamedicaUtils.Logger = logger;

VitamedicaUtils.Logger.LogInformation(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " Inicio Vitamedica");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();