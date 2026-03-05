public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int i = 0;
        foreach (char letter in input.ToUpper())
        {
            if ("AEIOULNRST".Contains(letter)) i += 1;
            else if ("DG".Contains(letter)) i += 2;
            else if ("BCMP".Contains(letter)) i += 3;
            else if ("FHVWY".Contains(letter)) i += 4;
            else if ("K".Contains(letter)) i += 5;
            else if ("JX".Contains(letter)) i += 8;
            else if ("QZ".Contains(letter)) i += 10;
            else i += 0;
        }
        return i;
    }
}