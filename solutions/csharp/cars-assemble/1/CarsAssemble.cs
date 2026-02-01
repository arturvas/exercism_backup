using System.Diagnostics;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0.0,
            >= 1 and <= 4 => 1.0,
            >= 5 and <= 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => throw new ArgumentOutOfRangeException(nameof(speed), "Invalid speed")
        };
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        if (speed is < 0 or > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(speed), "Invalid speed");
        }
        
        const double carsProducedPerHour = 221;
        
        return speed * carsProducedPerHour * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60; 
    }
}
