using System;
namespace csharpractice
{
  public class Solution1
  {
    public int MaxPower(string s)
    {
      if (s.Length == 1) return 1;
      if (s.Length == 0) return 0;
      int maxNum = 1;
      char currentChar = s[0];
      int currentNum = 1;

      for (int i=1; i<s.Length; i++)
      {
        if (currentChar == s[i])
        {
          currentNum++;
          maxNum = Math.Max(currentNum, maxNum);
        }
        else
        {
          currentNum = 1;
          currentChar = s[i];
        }

      }
      return maxNum;
    }
  }
}

