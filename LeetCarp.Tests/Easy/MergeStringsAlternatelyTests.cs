using LeetCarp.Easy;

namespace LeetCarp.Tests.Easy;

public class MergeStringsAlternatelyTests
{

    [Fact]
    public void TestMergeStringsExampleOne()
    {
        var word1 = "abc";
        var word2 = "pqr";
        var expected = "apbqcr";
        var actual = MergeStringsAlternately.MergeAlternately(word1, word2);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMergeStringsExampleTwo()
    {
        var word1 = "ab";
        var word2 = "pqrs";
        var expected = "apbqrs";
        var actual = MergeStringsAlternately.MergeAlternately(word1, word2);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMergeStringsExampleThree()
    {
        var word1 = "abcd";
        var word2 = "pq";
        var expected = "apbqcd";
        var actual = MergeStringsAlternately.MergeAlternately(word1, word2);
        Assert.Equal(expected, actual);
    }

}