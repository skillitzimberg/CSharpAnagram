using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Scrambler
  {
    private static string GivenWord;
    private static List<string> GivenListOfWords;

    public Scrambler(string givenWord, List<string> givenListOfWords)
    {
      GivenWord = givenWord;
      GivenListOfWords = givenListOfWords;

    }

     public List<string> ListOfScrambles()
     {
       List<string> result = new List<string>{};
       foreach (char letter in GivenWord)
       {
         for ( int i = 0; i < GivenListOfWords.Count; i++)
         {
           string characterAt = Convert.ToString(letter);
           if (GivenListOfWords[i].Contains(characterAt))
           result.Add(GivenListOfWords[i]);
         }
       }
         return result;
     }

     public static void ClearAll()
     {
       // GivenWord.Clear();
       GivenListOfWords.Clear();
     }

  }
}
