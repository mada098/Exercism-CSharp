public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        var foundIndex = str.IndexOf(delimiter);
        var startIndex = foundIndex + delimiter.Length;
        var newStr = str.Substring(startIndex, str.Length - startIndex);
        return newStr;
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstDelimiter, string secondDelimiter)
    {
        var indexFirstDel      = str.IndexOf(firstDelimiter);
        var startIndex         = indexFirstDel + firstDelimiter.Length;
        var indexSecDel        = str.IndexOf(secondDelimiter);
        return str.Substring(startIndex, indexSecDel - startIndex);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => SubstringAfter(str, ": ");
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => SubstringBetween(str, "[", "]");
}