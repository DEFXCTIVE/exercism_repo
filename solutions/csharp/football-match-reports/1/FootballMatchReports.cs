using System.Buffers;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        Dictionary<int, string> Lookup = new Dictionary<int, string>
        {

            {1, "goalie"},
            {2 , "left back"},
            {3 , "center back"},
           {4 , "center back"},
            {5 , "right back"},
            {6 , "midfielder"},
            {7 , "midfielder"},
            {8 , "midfielder"},
            {9 , "left wing"},
            {10 , "striker"},
            {11, "right wing"}
        };


        return  Lookup.TryGetValue(shirtNum,out var x) ? x : "UNKNOWN";

    }

    public static string AnalyzeOffField(object report) => report switch{
        int supporter => $"There are {supporter} supporters at the match.",
        string string_=> string_,
        Incident incident => $"{(!report.GetType().Name.Equals("Injury") ? incident.GetDescription() : "Oh no! "+incident.GetDescription()+ " Medics are on the field.")}",
        Manager manager => $"{manager.Name}{(manager.Club is not null ? " ("+manager.Club+")" : "")}",
        _ => ""
    };
   
}
