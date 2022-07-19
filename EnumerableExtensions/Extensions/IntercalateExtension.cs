namespace EnumerableExtensions.Extensions;

public static class IntercalateExtension
{
    public static IEnumerable<T> Intercalate<T>(
        this IEnumerable<T> insertEnumerable,
        IEnumerable<IEnumerable<T>> toFlatten
    )
    {
        var first = true;

        foreach (var innerEnumerable in toFlatten)
        {
            if (!first)
            {
                foreach (var insertElement in insertEnumerable)
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