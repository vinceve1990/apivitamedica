using Microsoft.EntityFrameworkCore;
using vitamedica.log;
using vitamedica.Models.ConexionBD;
using vitamedica.Models.ConexionRV;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configBuilder = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("/opt/services/VitamedicaConfig.json", optional: false, reloadOnChange: true);

//var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("vitamedica-config.json");

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

string logFilePath = "console_log.txt";

using (StreamWriter logFileWriter = new StreamWriter(logFilePath, append: true)) {
    //Create an ILoggerFactory
    ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
    {
        //Add console output
        builder.AddSimpleConsole(options =>
        {
            options.IncludeScopes = true;
            options.SingleLine = true;
            options.TimestampFormat = "HH:mm:ss ";
        });

        //Add a custom log provider to write logs to text files
        builder.AddProvider(new CustomFileLoggerProvider(logFileWriter));
    });

    //Create an ILogger
    ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

    // Output some text on the console
    using (logger.BeginScope("[scope is enabled]")) {
        logger.LogInformation("Hello World!");
        logger.LogInformation("Logs contain timestamp and log level.");
        logger.LogInformation("Each log message is fit in a single line.");
    }
}

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