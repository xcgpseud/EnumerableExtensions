using EnumerableExtensions.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace EnumerableExtensions.Tests.TestCases;

[TestFixture]
public class ConcatExtensionTests
{
    [Test]
    public void Concat_WithValidEnumerable_ReturnsCorrectEnumerable()
    {
        var enumerable = new List<List<int>>
        {
            new() { 1, 2, 3 },
            new() { 4, 5, 6 },
            new() { 7, 8, 9 },
        };
        var expectedResult = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var result = enumerable.Concat();

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void ConcatMap_WithValidEnumerable_ReturnsCorrectEnumerable_WithMappedValues()
    {
        var enumerable = new List<List<int>>
        {
            new() { 1, 2 },
            new() { 3, 4 },
        };
        int Fn(int i) => i * 2;
        var expectedResult = new List<int> { 2, 4, 6, 8 };

        var result = enumerable.ConcatMap(Fn);

        result.Should().BeEquivalentTo(expectedResult);
    }
}