using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class ScramblerTest
  {
    [TestMethod]
    public void ListOfScrambles_ReturnAnEmptyString_EmptyList()
    {
      List<string> newList = new List<string> {};
      Scrambler newAnagram = new Scrambler();

      List<string> result = newAnagram.ListOfScrambles();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AnagramCompiler_ReturnAllPossibleArrangementsOfAThreeLetterWord_ListOfWords()
    {
      string testWord = "hat";
      List<string> testList = new List<string> {"hat", "hta", }
      Scrambler newAnagram = new Scrambler(testWord);

      List<string> newScramble = newAnagram.AnagramCompiler();

      CollestionAssert.AreEqual(testWord.Contains(testWord[i]), newScramble);
    }
  }
}
