
public class ShipmentUtil {

    private const int DEFAULTVALUE = 5000;
    public static decimal CalculateBillableWeight(decimal weight, decimal lenght, decimal width, decimal breadth){

        var valumetriWeight = (lenght * width * breadth) / DEFAULTVALUE;

        var builableWeight = Math.Max(weight, valumetriWeight);

        return builableWeight;

    }
    
    public static int GetBaseRate(string serviceType)
    {

        //We can Swithcase here
        int baseRate = 0;
        if(serviceType == "Standard") {
            baseRate = 5;
        }
        else if(serviceType == "Express"){
            baseRate = 8;
        }

        return baseRate;

    }

    public static decimal GetZoneMultiplier(string destination){

        //We can Swithcase here
        decimal multiplier = 0;

        if(destination == "Local") {
            multiplier = 1;
        }
        else if (destination == "Regional"){
            multiplier = 1.5m;
        }
        else if(destination == "International"){
            multiplier = 2.5m;
        }

        return multiplier;

    }

}