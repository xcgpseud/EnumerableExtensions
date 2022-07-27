namespace EnumerableExtensions.Extensions;

public static class TransposeExtension
{
    public static IEnumerable<IEnumerable<T>> Transpose<T>(this IEnumerable<IEnumerable<T>> @this)
    {
        var first = true;
        for (
            var enumerators = @this.Select(t => t.GetEnumerator());
            enumerators.Any();
            enumerators = enumerators.Where(e => e.MoveNext())
        )
        {
            if (!first)
            {
                yield return enumerators.Select(e => e.Current);
            }

            first = false;
        }
    }
}