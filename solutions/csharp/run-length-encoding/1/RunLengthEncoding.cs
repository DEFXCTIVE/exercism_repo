
using System.Data.Common;
using System.Text;

public static class RunLengthEncoding
{
    class LetterCombo
    {
        public int count;
        public char letter;
        public LetterCombo(char x,int i)
        {
            this.letter = x;
            this.count = i;
        }
    }
    public static string Encode(string input)
    {
        // logic is traverse array and += sum until new character is different than last
        List<LetterCombo> chars = new List<LetterCombo>();
        char last_char = '!';
        StringBuilder s = new StringBuilder();
        foreach(char e in input)
        {
            if(!e.Equals(last_char))
            {
                chars.Add(new LetterCombo(e,1));
            }
            else
            {
                chars.Last().count+=1;
            }
            last_char = e;
        }
        Console.WriteLine(chars);
        chars.ForEach(item => s.Append((item.count > 1 ? item.count.ToString() : "") + item.letter.ToString()));

        return s.ToString();
    }

    public static string Decode(string input)
    {
       
       int i=0;
       StringBuilder builder = new StringBuilder();
       List<char> numberBuilding = new List<char>();
       while(i >= 0 && i < input.Length)
        {
            if(char.IsDigit(input[i]))
            {
                numberBuilding.Add(input[i]);
                i+=1;
                continue;
            }
            
            if (int.TryParse(new string(numberBuilding.ToArray()),out int number))
            {
                builder.Append(Enumerable.Repeat(input[i],number).ToArray());
            }
            else
            {
                builder.Append(input[i]);
            }
            numberBuilding.Clear();
           
           i+=1;
        }
        return builder.ToString();
    }
}
