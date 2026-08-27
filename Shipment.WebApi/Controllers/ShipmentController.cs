using Microsoft.AspNetCore.Mvc;
using Shipment.BusinessLayer;

[ApiController]
[Route("api/v1/[controller]")]
public class ShipmentController : ControllerBase
{

    private readonly IShipmentService _shipmentService;
    private readonly ILogger<ShipmentController> _logger;
    public ShipmentController(IShipmentService shipmentService, ILogger<ShipmentController> logger){
        _logger = logger;
        _shipmentService = shipmentService;

    }

    [HttpPost]
    [Route("rates/calculate")]
    public async Task<ShipmentResponse> GetShipmentRates(ShipmentRequest request)
    {

        _logger.LogInformation(request.ServiceType.ToString());
        _logger.LogInformation(request.Weight.ToString());
         _logger.LogInformation(request.Dimension.Width.ToString());
        return await _shipmentService.GetShipmentRates(request);
    }
}