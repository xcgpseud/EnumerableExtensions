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
        var enumerable = new List<int> { 1, 2 };
        var toFlatten = new List<List<int>> { new() { 5, 6 }, new() { 8, 9 }, new() { 1 } };
        var expectedResult = new List<int> { 5, 6, 1, 2, 8, 9, 1, 2, 1 };

        var result = enumerable.Intercalate(toFlatten);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Intercalate_WithValidInsertEnumerable_AndOneEnumerableToFlatten_ReturnsSingleEnumerableFlattened()
    {
        var enumerable = new List<int> { 1, 2 };
        var toFlatten = new List<List<int>> { new() { 5, 6 } };
        var expectedResult = new List<int> { 5, 6 };

        var result = enumerable.Intercalate(toFlatten);

        result.Should().BeEquivalentTo(expectedResult);
    }
}