using Microsoft.Testing.Platform.Logging;

static class LogLine
{
    
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(": ");
        if (index == -1)
        {
            return "";
        }
        
        string message = logLine.Substring(index + 2).Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        int iStartPos = logLine.IndexOf("[");
        int iEndPos = logLine.IndexOf("]");
        if (iEndPos == -1)
        {
            return "";
        }
        
        string level = logLine.Substring(iStartPos + 1, iEndPos - (iStartPos + 1)).ToLower();
        return level;
    }

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}
