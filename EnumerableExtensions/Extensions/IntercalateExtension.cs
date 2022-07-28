namespace EnumerableExtensions.Extensions;

public static class IntercalateExtension
{
    public static IEnumerable<T> Intercalate<T>(
        this IEnumerable<T> @this,
        IEnumerable<IEnumerable<T>> toFlatten
    )
    {
        var first = true;

        foreach (var innerEnumerable in toFlatten)
        {
            if (!first)
            {
                foreach (var insertElement in @this)
                {
                    yield return insertElement;
                }
            }

            foreach (var element in innerEnumerable)
            {
                yield return element;
            }

            first = false;
        }
    }
}