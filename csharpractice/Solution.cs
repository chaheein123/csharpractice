using System;
using System.Collections.Generic;

namespace csharpractice
{
  public class Solution
  {
    public int[] ShortestToChar(string S, char C)
    {
      List<int> zeroList = new List<int>();
      for (var i = 0; i < S.Length; i++)
      {
        if (S[i] == C) zeroList.Add(i);
      };
      zeroList.Insert(0,zeroList[0]);

      int rightPointer = 1, leftPointer = 0;
      int[] answer = new int[S.Length];
      for (int j = 0; j < S.Length; j++)
      {
        if (j == zeroList[rightPointer] && rightPointer<zeroList.Count-1)
        {
          rightPointer++;
          leftPointer++;
        }

        answer[j] = Math.Min(Math.Abs(j - zeroList[leftPointer]), Math.Abs(zeroList[rightPointer] - j));
      }







      foreach (var yo in answer)
      {
        Console.WriteLine(yo);
      };

      return new int[] { 1, 2, 3 };
    }
  }
}
