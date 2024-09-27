using LeetCarp.Easy;

namespace LeetCarp.Tests.Easy;

public class _345_ReverseVowelsTests
{

    [Fact]
    public void TestReverseVowelsExampleOne()
    {
        var input = "IceCreAm";
        var expected = "AceCreIm";
        var actual = _345_ReverseVowels.ReverseVowels(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestReverseVowelsExampleTwo()
    {
        var input = "leetcode";
        var expected = "leotcede";
        var actual = _345_ReverseVowels.ReverseVowels(input);
        Assert.Equal(expected, actual);
    }

}
