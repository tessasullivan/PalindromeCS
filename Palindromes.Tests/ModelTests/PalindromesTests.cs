using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTest
  {
    [TestMethod]
    public void PalindromeConstructor_CreatesInstanceOfPalindrome_Palindrome()
    {
        string phrase="A";
        bool test = false;
        Palindrome testPalindrome = new Palindrome(phrase, test);
        Assert.AreEqual(typeof(Palindrome), testPalindrome.GetType());
    }
    [TestMethod]
    public void GetPhrase_GetsPhrase_True()
    {
        string phrase="test";
        bool test = false;
        Palindrome testPalindrome = new Palindrome(phrase, test);
        string result = testPalindrome.GetPhrase();
        Assert.AreEqual(phrase, result);       
    }
    [TestMethod]
    public void GetIsPalindrome_GetsIsPalindrome_True()
    {
        string phrase="test";
        bool test = false;
        Palindrome testPalindrome = new Palindrome(phrase, test);
        bool result = testPalindrome.GetIsPalindrome();
        Assert.AreEqual(test, result);       
    }
    [TestMethod]
    public void SetPhrase_SetsPhrase_String()
    {
        string phrase="test";
        bool test = false;
        Palindrome testPalindrome = new Palindrome(phrase, test);
        string newPhrase = "foobar";
        testPalindrome.SetPhrase(newPhrase);
        string result = testPalindrome.GetPhrase();
        Assert.AreEqual(newPhrase, result);       
    }
        [TestMethod]
    public void SetIsPalindrome_SetsIsPalindrome_False()
    {
        string phrase="test";
        bool test = true;
        Palindrome testPalindrome = new Palindrome(phrase, test);
        bool test2 = false;
        testPalindrome.SetIsPalindrome(test2);
        bool result = testPalindrome.GetIsPalindrome();
        Assert.AreEqual(test2, result);       
    }
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