using EnumerableExtensions.Extensions;
using FluentAssertions;
using Microsoft.Win32.SafeHandles;
using NUnit.Framework;

namespace EnumerableExtensions.Tests.TestCases;

[TestFixture]
public class TransposeExtensionTests
{
    [Test]
    public void Transpose_WithSameLengthEnumerables_ReturnsCorrectTransposedEnumerable()
    {
        var enumerable = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 },
        };

        var expectedResult = new List<List<int>>
        {
            new List<int> { 1, 4, 7 },
            new List<int> { 2, 5, 8 },
            new List<int> { 3, 6, 9 },
        };

        var result = enumerable.Transpose();

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Transpose_WithDifferentLengthEnumerables_ReturnsCorrectTransposedEnumerable()
    {
        var enumerable = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4 },
            new List<int> { 7, 8 },
        };

        var expectedResult = new List<List<int>>
        {
            new List<int> { 1, 4, 7 },
            new List<int> { 2, 8 },
            new List<int> { 3 },
        };

        var result = enumerable.Transpose();

        result.Should().BeEquivalentTo(expectedResult);
    }
}