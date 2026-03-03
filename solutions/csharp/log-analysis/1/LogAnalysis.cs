public static class LogAnalysis 
{
    public static string SubstringAfter(this string str,string special_char) => str.Substring(str.IndexOf(special_char)+special_char.Length); 
    public static string SubstringBetween(this string str,string first_char,string second_char)
    {
        int first_index = str.IndexOf(first_char)+first_char.Length;
        int second_index = str.IndexOf(second_char);
        return str[first_index..second_index];
    }
    public static string Message(this string str) => str.SubstringAfter(": ");
    public static string LogLevel(this string str)=> str.SubstringBetween("[","]");
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    
    // TODO: define the 'Message()' extension method on the `string` type

    // TODO: define the 'LogLevel()' extension method on the `string` type
}