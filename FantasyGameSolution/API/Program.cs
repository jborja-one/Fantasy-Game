using System.Data;using API.Models;using API.Services;using Core.Repositories;using MySql.Data.MySqlClient;

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
    services.AddScoped<PlayerRepository>();
    services.AddScoped<UserRepository>();
}