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
        List<int> enumerable = new() { 1, 2, 3, 4, 5 };

        List<int> expectedResult = new() { 1, delimiter, 2, delimiter, 3, delimiter, 4, delimiter, 5 };

        var result = enumerable.Intersperse(delimiter);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Intersperse_WithOneEnumerableElement_AndValidDelimiter_ReturnsOnlyOneListElement()
    {
        const int delimiter = 9;
        List<int> enumerable = new() { 1 };
        List<int> expectedResult = new() { 1 };

        var result = enumerable.Intersperse(delimiter);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Intersperse_WithEmptyEnumerable_AndValidDelimiter_ReturnsEmptyList()
    {
        const int delimiter = 9;
        List<int> enumerable = new();

        var result = enumerable.Intersperse(delimiter);

        result.Should().BeEmpty();
    }
}