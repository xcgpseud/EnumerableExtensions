using EnumerableExtensions.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace EnumerableExtensions.Tests.TestCases;

[TestFixture]
public class IntercalateExtensionTests
{
    [Test]
    public void Intercalate_WithValidInsertEnumerable_AndValidFlattenEnumerable_ReturnsConcatenatedElements()
    {
        List<int> enumerable = new() { 1, 2 };
        List<List<int>> toFlatten = new() { new() { 5, 6 }, new() { 8, 9 }, new() { 1 } };

        List<int> expectedResult = new() { 5, 6, 1, 2, 8, 9, 1, 2, 1 };

        var result = enumerable.Intercalate(toFlatten);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Intercalate_WithValidInsertEnumerable_AndOneEnumerableToFlatten_ReturnsSingleEnumerableFlattened()
    {
        List<int> enumerable = new() { 1, 2 };
        List<List<int>> toFlatten = new() { new() { 5, 6 } };

        List<int> expectedResult = new() { 5, 6 };

        var result = enumerable.Intercalate(toFlatten);

        result.Should().BeEquivalentTo(expectedResult);
    }
}