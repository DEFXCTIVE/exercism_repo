using System.Text;

public static class Identifier
{

    public static string Clean(string identifier)
    {
        StringBuilder builder = new StringBuilder();
        bool shouldUpper = false;
        foreach (char l in identifier)
        {

            if (Char.IsControl(l))
            {
                builder.Append("CTRL");
                continue;
            }
            if (Char.IsWhiteSpace(l))
            {
                builder.Append('_');
                continue;
            }
            if (l.Equals('-'))
            {
                shouldUpper = true;
                continue;
            }
            if (!Char.IsLetter(l) || (l >= 'α' && l <= 'ω'))
            {
                shouldUpper = false;
                continue;
            }
            else if (shouldUpper)
            {
                shouldUpper = false;
                builder.Append(char.ToUpper(l));
                continue;
            }
            builder.Append(l);
        }
        return builder.ToString();
    }
}
