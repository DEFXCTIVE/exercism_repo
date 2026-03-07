using System.Xml.Serialization;

public static class DifferenceOfSquares
{
    public static int[] GetInts(int max)
    {
        int[] array = new int[max];
        int i;
        for(i=0;i<max;i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    public static int CalculateSquareOfSum(int max)=> (int) Math.Pow(GetInts(max).Aggregate(0,(s,n)=>s+n),2);

    public static int CalculateSumOfSquares(int max) => (int) GetInts(max).Aggregate(0,(s,n)=>s+(n*n));

    public static int CalculateDifferenceOfSquares(int max)=> (int) CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}