namespace EnumerableExtensions.Extensions;

public static class PartitionExtension
{
    public static (IEnumerable<T>, IEnumerable<T>) Partition<T>(this IEnumerable<T> enumerable, Func<T, bool> fn)
    {
        List<T> matched = new();
        List<T> unMatched = new();

        foreach (var element in enumerable)
        {
            if (fn(element))
            {
                matched.Add(element);
            }
            else
            {
                unMatched.Add(element);
            }
        }
        
        return (matched, unMatched);
    }
}