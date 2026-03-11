using System.Collections;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public static class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        var items = new List<object>();
        foreach (object item in input)
        {
            if (item is null) continue;
            else if (item is IEnumerable && item is not string)
            {
                foreach(object x in Flatten((IEnumerable)item))
                {
                  items.Add(x);
                }
                continue;
            }
            else
            {
                items.Add(item);
            }
        }
        return items;
    }
}