namespace EnumerableExtensions.Extensions;

public static class PartitionExtension
{
    public static (IEnumerable<T>, IEnumerable<T>) Partition<T>(this IEnumerable<T> @this, Func<T, bool> fn)
    {
        List<T> matched = new();
        List<T> unMatched = new();

        foreach (var element in @this)
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