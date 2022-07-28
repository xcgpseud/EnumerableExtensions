namespace EnumerableExtensions.Extensions;

public static class ConcatExtension
{
    public static IEnumerable<T> Concat<T>(this IEnumerable<IEnumerable<T>> @this)
    {
        foreach (var innerList in @this)
        {
            foreach (var innerElement in innerList)
            {
                yield return innerElement;
            }
        }
    }

    public static IEnumerable<T> ConcatMap<T>(this IEnumerable<IEnumerable<T>> @this, Func<T, T> fn)
    {
        foreach (var innerList in @this)
        {
            foreach (var innerElement in innerList)
            {
                yield return fn(innerElement);
            }
        }
    }
}