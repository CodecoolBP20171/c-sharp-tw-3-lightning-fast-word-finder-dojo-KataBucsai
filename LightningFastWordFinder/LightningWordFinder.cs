using System;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string[] words = text.Split(' ');
            string result = "";
            foreach (var word in words)
            {
                if (Regex.IsMatch(word, @"^[a-zA-Z]+$"))
                {
                    if (word.Length > result.Length)
                    {
                        result = word;
                    }
                }
            }
            return result;
        }
    }
}
