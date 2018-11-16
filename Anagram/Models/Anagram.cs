using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class AnagramSearch
  {
    private string GivenWord;
    private List<string> GivenListOfWords;

    public AnagramSearch(string givenWord, List<string> givenListOfWords)
    {
      GivenWord = givenWord;
      GivenListOfWords = givenListOfWords;
    }

    public string GetGivenWord()
    {
      return GivenWord;
    }

    public List<string> GetGivenListOfWords()
    {
      return GivenListOfWords;
    }

    public List<string> DoesListContainAnagramsOfWord()
    {
      List<string> listOfMatchingWordsFound = new List<string> {};

      for (int index = 0; index < GivenListOfWords.Count; index++)
      {
        foreach (char letter in GivenWord)
        {
          if 
        }
        if (GivenListOfWords[index] == GivenWord)
        {
        listOfMatchingWordsFound.Add(GivenListOfWords[index]);
        }
      }
      return listOfMatchingWordsFound;
    }

    // public List<string> CompareWordToList()
    // {
    //   List<string> result = new List<string>{};
    //   Console.WriteLine(GivenListOfWords[0]);
    //
    //
    //   if (GivenWord == GivenListOfWords[0])
    //   {
    //     result = GivenListOfWords;
    //   }
    //   return result;
    // }
  }
}
