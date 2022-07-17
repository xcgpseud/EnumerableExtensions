namespace ListExtensions.Extensions;

public static class PartitionExtension
{
    public static (List<T>, List<T>) Partition<T>(this IEnumerable<T> list, Func<T, bool> fn)
    {
        List<T> matched = new();
        List<T> unMatched = new();

        foreach (var element in list)
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