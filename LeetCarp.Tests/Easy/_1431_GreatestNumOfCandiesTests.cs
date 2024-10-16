using LeetCarp.Easy;

namespace LeetCarp.Tests.Easy;

public class _1431_GreatestNumOfCandiesTests
{

    [Fact]
    public void TestCandiesExampleOne()
    {
        var input = new int[] { 2, 3, 5, 1, 3 };
        var extraCandies = 3;
        var expected = new List<bool> { true, true, true, false, true };
        var actual = _1431_GreatestNumOfCandies.KidsWithCandies(input, extraCandies);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestCandiesExampleTwo()
    {
        var input = new int[] { 4, 2, 1, 1, 2 };
        var extraCandies = 1;
        var expected = new List<bool> { true, false, false, false, false };
        var actual = _1431_GreatestNumOfCandies.KidsWithCandies(input, extraCandies);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestCandiesExampleThree()
    {
        var input = new int[] { 12, 1, 12 };
        var extraCandies = 10;
        var expected = new List<bool> { true, false, true };
        var actual = _1431_GreatestNumOfCandies.KidsWithCandies(input, extraCandies);
        Assert.Equal(expected, actual);
    }

}
