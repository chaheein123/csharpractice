using System;
using System.Linq;

namespace csharpractice
{
  public class Solution5
  {
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
      int max = nums.Max();
      int[] dp = new int[max + 2], res = new int[nums.Length];

      for (int i = 0; i < nums.Length; i++)
      {
        for (int j = nums[i] + 1; j < dp.Length; j++)
        {
          dp[j]++;
        }
      }

      for (int k = 0; k < res.Length; k++)
      {
        res[k] = dp[nums[k]];
      }
      return res;
    }

    public int NumberOfSteps(int num)
    {
      int answer = 0;
      while (num > 0)
      {
        answer++;
        num = (num % 2 == 0) ? num / 2 : num - 1;
      }

      return answer;
    }
  }
}
