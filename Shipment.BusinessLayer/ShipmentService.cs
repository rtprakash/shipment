
public class ShipmentService : IShipmentService
{

    public async Task<ShipmentResponse> GetShipmentRates(ShipmentRequest request)
    {

        var billableWeight =  ShipmentUtil.CalculateBillableWeight(request.Weight, 
                            request.Dimension.Width, request.Dimension.Length, request.Dimension.Breadth);


        var baseRate = ShipmentUtil.GetBaseRate(request.ServiceType);

        var zoneMultiplier = ShipmentUtil.GetZoneMultiplier(request.DestinationZone);

        var finalPrice = billableWeight * baseRate * zoneMultiplier;

        var priceBreakDown = new PriceBreakDown {
            BaseRate = baseRate,
            ZoneMultiplier = zoneMultiplier
        };

        return new ShipmentResponse{
            BillableWeight = billableWeight,
            FinalPrice = finalPrice,
            PriceBreakDown = priceBreakDown
        };
    }
}