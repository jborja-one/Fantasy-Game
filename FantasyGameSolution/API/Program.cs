using System.Data;using API.Models;using API.Services;using Core.Repositories;using MySql.Data.MySqlClient;//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<JobService>();
//builder.Services.AddScoped<ActionService>();
//builder.Services.AddScoped<AbilityService>();
//builder.Services.AddScoped<SpellService>();

//var app = builder.Build();

//var config = new ConfigurationBuilder()
//                        .SetBasePath(Directory.GetCurrentDirectory())
//                        .AddJsonFile("appsettings.json")
//                        .Build();//string connString = config.GetConnectionString("DefaultConnection");//IDbConnection connection = new MySqlConnection(connString);

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

var builder = WebApplication.CreateBuilder(args);

// Configure services
ConfigureServices(builder.Services, builder.Configuration);

// Add database connection
builder.Services.AddScoped<IDbConnection>((s) =>
{
    IDbConnection conn = new MySqlConnection(builder.Configuration.GetConnectionString("DefaultConnection"));
    conn.Open();
    return conn;
});


var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    // Add framework services
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    // Add application services
    services.AddSingleton<JobService>();
    services.AddScoped<ActionService>();
    services.AddScoped<AbilityService>();
    services.AddScoped<SpellService>();
    services.AddScoped<CharacterRepository>();

}