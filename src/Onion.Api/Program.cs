using Onion.Infrastrucure.Configurations;

var builder = WebApplication.CreateBuilder(args);


// Register Infrastructure services
builder.Services.AddInfrastructure(builder.Configuration);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o =>
{
    o.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Onion Architecture",
        Version = "v1",
        Description = "API for Onion Architecture"
    });
});

var app = builder.Build();

// Enable middleware
app.UseSwagger();
app.UseSwaggerUI(o =>
{
    o.SwaggerEndpoint("/swagger/v1/swagger.json", "Auth V1");
    o.RoutePrefix = string.Empty; // Swagger UI at root
});

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
