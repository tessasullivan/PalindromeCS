using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTest
  {
    [TestMethod]
    public void IsPalindrome_SingleChar_True()
    {
        string phrase="A";
        bool test = false;
        Palindrome testPalindrome = new Palindrome(phrase, test);
        testPalindrome.IsPalindromeTest(phrase);
        Assert.AreEqual(true, testPalindrome.GetIsPalindrome());
    }

    // [TestMethod]
    // public void IsPalindrome_WordIsPalindromeEvenNumberOfChars_True()
    // {
    //     Palindrome testPalindrome = new Palindrome();
    //     Assert.AreEqual(true, testPalindrome.IsPalindrome("noon"));
    // }
    // [TestMethod]
    // public void IsPalindrome_WordIsPalindromeOddNumberOfChars_True()
    // {
    //     Palindrome testPalindrome = new Palindrome();
    //     Assert.AreEqual(true, testPalindrome.IsPalindrome("madam"));
    // }
    // [TestMethod]
    // public void IsPalindrome_NumberIsPalindrome_True()
    // {
    //     Palindrome testPalindrome = new Palindrome();
    //     Assert.AreEqual(true, testPalindrome.IsPalindrome("4554"));
    // }
    // [TestMethod]
    // public void IsPalindrome_WordIsPalindrome_False()
    // {
    //     Palindrome testPalindrome = new Palindrome();
    //     Assert.AreEqual(false, testPalindrome.IsPalindrome("jump"));
    // }
  }
}