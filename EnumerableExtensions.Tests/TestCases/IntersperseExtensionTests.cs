using EnumerableExtensions.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace EnumerableExtensions.Tests.TestCases;

[TestFixture]
public class IntersperseExtensionTests
{
    [Test]
    public void Intersperse_WithValidEnumerable_AndValidDelimiter_ReturnsCorrectResult()
    {
        const int delimiter = 9;
        var enumerable = new List<int> { 1, 2, 3, 4, 5 };
        var expectedResult = new List<int> { 1, delimiter, 2, delimiter, 3, delimiter, 4, delimiter, 5 };

        var result = enumerable.Intersperse(delimiter);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Intersperse_WithOneEnumerableElement_AndValidDelimiter_ReturnsOnlyOneListElement()
    {
        const int delimiter = 9;
        var enumerable = new List<int> { 1 };
        var expectedResult = new List<int> { 1 };

        var result = enumerable.Intersperse(delimiter);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Intersperse_WithEmptyEnumerable_AndValidDelimiter_ReturnsEmptyList()
    {
        const int delimiter = 9;
        var enumerable = new List<int>();

        var result = enumerable.Intersperse(delimiter);

        result.Should().BeEmpty();
    }
}