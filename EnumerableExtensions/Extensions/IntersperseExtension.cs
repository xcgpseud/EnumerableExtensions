namespace EnumerableExtensions.Extensions;

public static class IntersperseExtension
{
    public static IEnumerable<T> Intersperse<T>(this IEnumerable<T> @this, T separator)
    {
        var first = true;
        foreach (var value in @this)
        {
            // We don't want the delimiter to be BEFORE the other elements. Also covers empty lists / 1 element
            if (!first)
            {
                yield return separator;
            }

            yield return value;
            first = false;
        }
    }
}