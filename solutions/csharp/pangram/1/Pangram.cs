public static class Pangram
{
    public static bool IsPangram(string input) => input.Select(char.ToLowerInvariant).Distinct().Aggregate(0,(total,next)=>char.IsAsciiLetter(next) ? total + 1: total) == 26;
}
