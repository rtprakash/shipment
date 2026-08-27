

public class ShipmentRequest {
    public decimal Weight { get; set;}
    public ShipmentDimension Dimension { get; set;}
    public string ServiceType {get; set;}
    public string DestinationZone { get; set;}
}