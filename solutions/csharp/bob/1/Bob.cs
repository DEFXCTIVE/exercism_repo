public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        Console.WriteLine($"Statement: '{statement}'");
        if (statement.Length == 0) return "Fine. Be that way!";
        bool isYelling = statement.Equals(statement.ToUpper()) && statement.Any(char.IsLetter);
        Console.WriteLine($"Last character: '{statement[statement.Length - 1]}'");
        bool isQuestion = statement[statement.Length - 1].ToString().Equals("?");
        Console.WriteLine($"Is yelling: {isYelling}");
        Console.WriteLine($"Is question: {isQuestion}");
        if (isYelling && isQuestion) return "Calm down, I know what I'm doing!";
        if (isQuestion) return "Sure.";
        if (isYelling) return "Whoa, chill out!";
        
        return "Whatever.";
    }
}