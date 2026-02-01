public static class Darts
{
    public static int Score(double x, double y) =>
        _distance(x, y) switch
        {
            <= 1 => 10,
            <= 5 => 5,
            <= 10 => 1,
            _ => 0
        };

    private static double _distance(double x, double y) => Math.Sqrt(x * x + y * y);
}
