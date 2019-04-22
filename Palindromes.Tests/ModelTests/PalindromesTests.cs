using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromesTest
  {
    [TestMethod]
    public void IsPalindrome_SingleChar_True()
    {
    // any necessary logic to prep for test; instantiating new classes, etc.
        Palindromes testPalindrome = new Palindromes();
        Assert.AreEqual(true, testPalindrome.IsPalindrome("A"));
    }

    [TestMethod]
    public void IsPalindrome_WordIsPalindromeEvenNumberOfChars_True()
    {
        Palindromes testPalindrome = new Palindromes();
        Assert.AreEqual(true, testPalindrome.IsPalindrome("noon"));
    }
    [TestMethod]
    public void IsPalindrome_WordIsPalindromeOddNumberOfChars_True()
    {
        Palindromes testPalindrome = new Palindromes();
        Assert.AreEqual(true, testPalindrome.IsPalindrome("madam"));
    }
    [TestMethod]
    public void IsPalindrome_NumberIsPalindrome_True()
    {
        Palindromes testPalindrome = new Palindromes();
        Assert.AreEqual(true, testPalindrome.IsPalindrome("4554"));
    }
    [TestMethod]
    public void IsPalindrome_WordIsPalindrome_False()
    {
        Palindromes testPalindrome = new Palindromes();
        Assert.AreEqual(false, testPalindrome.IsPalindrome("jump"));
    }
  }
}