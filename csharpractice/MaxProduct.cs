using System;
namespace csharpractice
{
  public class Solution2
  {
    public int MaxProduct(int[] nums)
    {
      int max = Math.Max(nums[0], nums[1]);
      int secMax = (max == nums[0]) ? nums[1] : nums[0];
      for (int i = 2; i < nums.Length; i++)
      {
        if (nums[i] >= max)
        {
          secMax = max;
          max = nums[i];
        }
        else if (nums[i] < max && nums[i] > secMax)
        {
          secMax = nums[i];
        }
      }
      return (max-1) * (secMax-1);
    }
  }
}
