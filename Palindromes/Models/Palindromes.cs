using System;

namespace Palindromes.Models
{
    public class Palindrome
    {
        private string _phrase;
        private bool _isPalindrome;
        public Palindrome(string phrase, bool isPalindrome)
        {
            _phrase = phrase;
            _isPalindrome = isPalindrome;
        }
        public string GetPhrase()
        {
            return _phrase;
        }
        public void SetPhrase (string phrase)
        {
            _phrase = phrase;
        }
        public bool GetIsPalindrome()
        {
            return _isPalindrome;
        }
        public void SetIsPalindrome(bool isPalindrome)
        {
            System.Console.WriteLine("in setIsPalindrome Before " + GetIsPalindrome());
            _isPalindrome = isPalindrome;
            System.Console.WriteLine("in setIsPalindrome after " + GetIsPalindrome());

        }
        public void IsPalindromeTest(string phrase)
        {
            Palindrome newPalidrome = new Palindrome(phrase, true);

            if (phrase.Length == 1)
            {
                System.Console.WriteLine("in phrase length 1");
                newPalidrome.SetIsPalindrome(true);
                System.Console.WriteLine("in phrase length 1 after " + newPalidrome.GetIsPalindrome());
                return;
            }
            // Need to declare string variable here, even though we're doing a new string later
            string reversedPhraseStr;
            char[] reversedPhrase = phrase.ToCharArray();
            Array.Reverse(reversedPhrase);
            reversedPhraseStr = new string(reversedPhrase);
            bool test = phrase.Equals(reversedPhraseStr, StringComparison.OrdinalIgnoreCase);
            if (test) 
            {
                System.Console.WriteLine("in if test is true before");
                newPalidrome.SetIsPalindrome(true);
            }
            else
            {
                newPalidrome.SetIsPalindrome(false);
            }
        }
    }
}