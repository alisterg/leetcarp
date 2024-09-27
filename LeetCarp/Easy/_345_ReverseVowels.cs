using System.Collections.Generic;

namespace LeetCarp.Easy;

public class _345_ReverseVowels
{
    private static readonly List<char> VOWELS = ['A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'];

    /// <summary>
    /// Given a string s, reverse only all the vowels in the string and return it.
    ///
    /// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both
    /// lower and upper cases, more than once.
    /// </summary>
    /// <param name="s">The input of which to reverse the vowels</param>
    /// <returns></returns>
    public static string ReverseVowels(string s)
    {
        var vowelsInString = GetVowelsInString(s);
        return GetVowelsSwapped(s, vowelsInString);
    }

    private static List<char> GetVowelsInString(string input)
    {
        var result = new List<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!VOWELS.Contains(input[i])) continue;
            result.Add(input[i]);
        }

        return result;
    }

    private static string GetVowelsSwapped(string s, List<char> vowelsInString)
    {
        var result = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (!VOWELS.Contains(s[i]))
            {
                result += s[i];
                continue;
            }

            var lastEle = vowelsInString[^1];
            vowelsInString.RemoveAt(vowelsInString.Count - 1);
            result += lastEle;
        }

        return result;
    }
}
