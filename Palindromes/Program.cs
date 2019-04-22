using System;

namespace Palindromes
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word to find out if it is a Palindrome!");
            string userInput = Console.ReadLine();
            bool test = userInput.IsPalindrome(userInput);
            if (test)
            {
                Console.WriteLine("This is a palindrome");
            }
            else
            {
                System.Console.WriteLine("this is not a palindrome");
            }
        }
    }
}