using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramSearchTest
  {
    [TestMethod]
    public void AnagramSearchConstructor_CreatesNewInstanceOfAnagramSearch_AnagramSearch()
    {
      string expectedWord = "ant";
      List<string> expectedListOfWords = new List<string> {"ant"};
      AnagramSearch newAnagramSearch = new AnagramSearch(expectedWord, expectedListOfWords);
      Assert.AreEqual(typeof(AnagramSearch), newAnagramSearch.GetType());
    }

    [TestMethod]
    public void GetGivenWord_ReturnsTheValueOfAnagramSearchPropertyGivenWord_String()
    {
      string expectedWord = "ant";
      List<string> expectedListOfWords = new List<string> {"ant"};
      AnagramSearch newAnagramSearch = new AnagramSearch(expectedWord, expectedListOfWords);

      string actualWord = newAnagramSearch.GetGivenWord();

      Assert.AreEqual(expectedWord, actualWord);
    }

    [TestMethod]
    public void GetGivenListOfWords_ReturnsTheValueOfAnagramSearchPropertyGivenListOfWords_ListOfStrings()
    {
      string expectedWord = "ant";
      List<string> expectedListOfWords = new List<string> {"ant"};
      AnagramSearch newAnagramSearch = new AnagramSearch(expectedWord, expectedListOfWords);

      List<string> actualListOfWords = newAnagramSearch.GetGivenListOfWords();

      Assert.AreEqual(expectedListOfWords, actualListOfWords);
    }

    [TestMethod]
    public void DoesListContainAnagramsOfWord_ReturnsListOfWordsThatMatchTheWordExactly_ListOfStrings()
    {
      string wordToSearchFor = "ant";
      List<string> expectedListOfMatchingWords = new List<string> {"ant", "ant"};
      List<string> listOfWordsToSearch = new List<string> {"cat", "dog", "ant", "fish", "turtle", "ant"};

      AnagramSearch newAnagramSearch = new AnagramSearch(wordToSearchFor, listOfWordsToSearch);

      List<string> listOfMatchingWordsFound = newAnagramSearch.DoesListContainAnagramsOfWord();

      CollectionAssert.AreEqual(expectedListOfMatchingWords, listOfMatchingWordsFound);
    }

    [TestMethod]
    public void DoesListContainAnagramsOfWord_ReturnsListOfWordsThatAreAnagramsOfTheWord_ListOfStrings()
    {
      string wordToSearchFor = "ant";
      List<string> expectedListOfMatchingWords = new List<string> {"tan"};
      List<string> listOfWordsToSearch = new List<string> {"tan"};

      AnagramSearch newAnagramSearch = new AnagramSearch(wordToSearchFor, listOfWordsToSearch);

      List<string> listOfMatchingWordsFound = newAnagramSearch.DoesListContainAnagramsOfWord();

      CollectionAssert.AreEqual(expectedListOfMatchingWords, listOfMatchingWordsFound);
    }

    // [TestMethod]
    // public void CompareWordToList_ReturnAnEmptyListOfStrings_EmptyListOfStrings()
    // {
    //   List<string> newList = new List<string> {};
    //   string testWord = "";
    //   List<string> testList = new List<string> {};
    //   AnagramSearch newAnagramSearch = new AnagramSearch(testWord, testList);
    //
    //   List<string> result = newAnagramSearch.ListOfScrambles();
    //
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void ListOfScrambles_ReturnGivenListOfWords_ListOfWords()
    // {
    //   List<string> expectedList = new List<string> {"ant"};
    //
    //   string testWord = "ant";
    //
    //   Scrambler newAnagram = new Scrambler(testWord, expectedList);
    //
    //   List<string> actualList = newAnagram.ListOfScrambles();
    //   foreach (string word in actualList)
    //   {
    //     Console.WriteLine("Actual list: " + actualList[0]);
    //   }
    //   CollectionAssert.AreEqual(expectedList, actualList);
    // }
  }
}
