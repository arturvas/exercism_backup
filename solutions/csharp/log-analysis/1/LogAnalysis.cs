public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str,  string substr)
    {
        int startIndex = str.IndexOf(substr, StringComparison.Ordinal);
        return str.Substring(startIndex + substr.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstSubstr,  string secondSubstr)
    {
        int startIndex = str.IndexOf(firstSubstr, StringComparison.Ordinal) + firstSubstr.Length;
        int endIndex = str.IndexOf(secondSubstr, StringComparison.Ordinal);
        
        string level = str.Substring(startIndex, endIndex - startIndex);
        return level;
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        int index = str.IndexOf(": ", StringComparison.Ordinal);
        return str.Substring(index + 1,  str.Length - (index + 1)).Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        int indexStart = str.IndexOf("[",  StringComparison.Ordinal);
        int indexEnd = str.IndexOf("]", StringComparison.Ordinal);
        string level = str.Substring(indexStart + 1, indexEnd - (indexStart + 1));
        return level;
    }
    
}
