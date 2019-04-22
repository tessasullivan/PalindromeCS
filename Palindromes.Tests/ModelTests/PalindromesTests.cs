using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromesTest
  {
    [TestMethod]
    public void UserInputsAChar_CharInputtedReturned_True()
    {
    // any necessary logic to prep for test; instantiating new classes, etc.
    Palindromes testPalindrome = new Palindromes();
    Assert.AreEqual(true, testPalindrome.IsPalindrome("A"));
    }
  }
}