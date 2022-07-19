using FluentAssertions;
using EnumerableExtensions.Extensions;
using NUnit.Framework;

namespace EnumerableExtensions.Tests.TestCases;

[TestFixture]
public class PartitionExtensionTests
{
    [Test]
    public void Partition_WithValidEnumerable_AndValidFunction_ReturnsMatchedAndUnMatched()
    {
        // ARRANGE
        var enumerable = Enumerable.Range(1, 10);
        var expectedMatches = new List<int> { 2, 4, 6, 8, 10 };
        var expectedUnMatches = new List<int> { 1, 3, 5, 7, 9 };

        // ACT
        var (matches, unMatches) = enumerable.Partition(i => i % 2 == 0);

        // ASSERT
        matches.Should().BeEquivalentTo(expectedMatches);
        unMatches.Should().BeEquivalentTo(expectedUnMatches);
    }

    [Test]
    public void Partition_WithEmptyEnumerable_AndValidFunction_ReturnsTwoEmptyLists()
    {
        // ACT
        List<int> enumerable = new();

        // ACT
        var (matched, unMatched) = enumerable.Partition(i => i % 2 == 0);
        
        // ASSERT
        matched.Should().BeOfType<List<int>>().And.BeEmpty();
        unMatched.Should().BeOfType<List<int>>().And.BeEmpty();
    }
}