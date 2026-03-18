public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand) { 
        if(firstStrand.Length != secondStrand.Length) throw new ArgumentException();
        
        return firstStrand.Where((item,index)=>item != secondStrand.ToCharArray()[index]).Count();
    }
}