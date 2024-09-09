using FluentAssertions;

namespace ExercisesTests.Arrays.Sort;

public class MergeSortTests
{
    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new int[][] {[1, 3], [2, 6], [8, 10], [15,18]},
            new int[][] {[1,6],[8,10],[15,18]},
        ];

        yield return
        [
            new int[][] {[1,4],[4,5]},
            new int[][] {[1,5]},
        ];
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void Test1(int[][] intervals, int[][] expected)
    {
        // Arrange
        // Act
        var result = Exercises.Arrays.Sort.MergeSort(intervals);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}