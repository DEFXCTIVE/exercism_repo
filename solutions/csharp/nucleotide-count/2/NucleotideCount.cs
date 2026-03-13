public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char,int> workingDictionary = new Dictionary<char, int>{
            {'A',0},
            {'C',0},
            {'G',0},
            {'T',0},
        };
        if(!sequence.All(e=> workingDictionary.ContainsKey(e))) throw new ArgumentException();
        foreach(char x in sequence)
        {
            workingDictionary[x]+=1;
        }
        return workingDictionary;
    }
}