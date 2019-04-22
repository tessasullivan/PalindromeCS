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
            else
            {
                return false;
            }
        }
    }
}