public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        if (input.Length == 0)
            return -1;
        
        var low = 0;
        var high = input.Length - 1;

        while (low <= high)
        {
            var middle = (low + high) / 2;
            var guess = input[middle];
            
            if (guess == value)
                return middle;
            
            if (guess > value)
                high = middle - 1;
            else
                low = middle + 1;
        }
        
        return -1;
    }
}