public static class SumOfMultiples
{

    public static int Sum(IEnumerable<int> multiples, int max) => multiples.SelectMany(x => Enumerable.Range(1,max).Select((b) => b * x).Where(num => num < max)).Distinct().Sum();
}