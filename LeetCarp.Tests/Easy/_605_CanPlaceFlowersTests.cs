using LeetCarp.Easy;

namespace LeetCarp.Tests.Easy;

public class _605_CanPlaceFlowersTests
{

    [Fact]
    public void TestCanPlaceFlowersExampleOne()
    {
        var flowerbed = new[] {1,0,0,0,1};
        var n = 1;
        var expected = true;
        var actual = _605_CanPlaceFlowers.CanPlaceFlowers(flowerbed, n);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestCanPlaceFlowersExampleTwo()
    {
        var flowerbed = new[] {1,0,0,0,1};
        var n = 2;
        var expected = false;
        var actual = _605_CanPlaceFlowers.CanPlaceFlowers(flowerbed, n);
        Assert.Equal(expected, actual);
    }

}
