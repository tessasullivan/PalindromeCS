using System;

namespace Palindromes
{
    public class Palindromes
    {
        public bool IsPalindrome(string phrase)
        {
            if (phrase.Length == 1)
            {
                return true;
            }
            // Need to declare string variable here, even though we're doing a new string later
            string reversedPhraseStr;
            char[] reversedPhrase = phrase.ToCharArray();
            Array.Reverse(reversedPhrase);
            reversedPhraseStr = new string(reversedPhrase);
            bool test = phrase.Equals(reversedPhraseStr, StringComparison.OrdinalIgnoreCase);
            if (test) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}