public static class ReverseString
{
    public static string Reverse(string input)
    {
        string newReversedString = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            newReversedString += input[i];
        }
        
        return newReversedString;
    }
}