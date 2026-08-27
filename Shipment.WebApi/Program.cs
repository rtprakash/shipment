using Shipment.BusinessLayer;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services.AddControllers();

builder.Services.AddScoped<IShipmentService, ShipmentService>();

var app = builder.Build();


app.UseHttpsRedirection();

app.MapControllers();

app.Run();


