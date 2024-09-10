namespace LeetCarp.Easy;

public class MergeStringsAlternately
{
    /// <summary>
    /// Merge the two input strings by adding letters in alternating order,
    /// starting with `word1`. Append any remaining letters.
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    /// <returns></returns>
    public static string MergeAlternately(string word1, string word2)
    {
        var result = "";

        for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
        {
            try { result += word1[i]; } catch {}
            try { result += word2[i]; } catch {}
        }

        return result;
    }
}
