public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max) => 
        Enumerable.Range(1, max).Select(i => (i * i) * i).Sum();

    public static int CalculateSumOfSquares(int max) => 
        Enumerable.Range(1, max).Select(i => i * i).Sum();

    public static int CalculateDifferenceOfSquares(int max) => 
        CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}