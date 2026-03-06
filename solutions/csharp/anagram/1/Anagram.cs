using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Anagram
{
    string baseWord;
    public Anagram(string baseWord)
    {
        this.baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> matches = new List<string>();
        foreach (string word in potentialMatches)
        {
            if (!(string.Compare(word,this.baseWord,true) == 0) && word.Length == this.baseWord.Length)
            {
                int matchedLetters = 0;
                List<int> passedPositions = new List<int>();
                foreach (char letter in word)
                {   
                    int i =0;
                    for (i=0;i<this.baseWord.Length;i++)
                    {   
                        string char1,char2;
                        char1 = letter.ToString();
                        char2 = this.baseWord[i].ToString();
                        if (!passedPositions.Contains(i) && string.Compare(char1,char2,true) == 0)
                        {
                            matchedLetters+=1;
                            passedPositions.Add(i);
                            break;
                        }
                    }
                }
                if (matchedLetters == word.Length) matches.Add(word);
            }
        }
        return matches.ToArray();
    }
}