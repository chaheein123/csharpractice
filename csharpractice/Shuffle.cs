using System;
namespace csharpractice
{
  public class Solution3
  {
    public int[] Shuffle(int[] nums, int n)
    {

      int[] answer = new int[nums.Length];

      for (int i=0, j=n, k=0; k<answer.Length; i++, j++, k+=2)
      {
        answer[k] = nums[i];
        answer[k + 1] = nums[j];
      }
      return answer;
    }
  }
}
