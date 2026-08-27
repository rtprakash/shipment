
public interface IShipmentService 
{
    Task<ShipmentResponse> GetShipmentRates(ShipmentRequest request);
}