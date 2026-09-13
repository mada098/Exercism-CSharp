static class LogLine
{
    public static string Message(string logLine) => logLine.Split("]:")[1].Trim();

    public static string LogLevel(string logLine)
    {
        var foundIndexLength = logLine.IndexOf("]") - 1;
        return logLine.Substring(1, foundIndexLength).ToLower(); 
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
