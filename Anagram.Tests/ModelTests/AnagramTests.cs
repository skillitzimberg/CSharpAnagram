using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class ScramblerTest : IDisposable
  {
    public void Dispose()
    {
      Scrambler.ClearAll();
    }

    [TestMethod]
    public void ListOfScrambles_ReturnAnEmptyString_EmptyList()
    {
      List<string> newList = new List<string> {};
      string testWord = "";
      List<string> testList = new List<string> {};
      Scrambler newAnagram = new Scrambler(testWord, testList);

      List<string> result = newAnagram.ListOfScrambles();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ListOfScrambles_ReturnAllPossibleArrangementsOfAThreeLetterWord_ListOfWords()
    {
      List<string> expectedList = new List<string> {"dog", "fish", "ant"};
      string testWord = "tan";
      Scrambler newAnagram = new Scrambler(testWord, expectedList);

      List<string> actualList = newAnagram.ListOfScrambles();

      foreach (string word in expectedList)
      {
        Console.WriteLine("Output from expectedList test: " + expectedList);
      }

      foreach (string word in actualList)
      {
        Console.WriteLine("Output from second ListOfScrambles test: " + newAnagram.ListOfScrambles());
      }

      CollectionAssert.AreEqual(expectedList, actualList);
    }
  }
}
