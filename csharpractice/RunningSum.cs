using System;
namespace csharpractice
{
  public class Solution4
  {
		public int[] RunningSum(int[] nums)
		{
			for (int i = 1; i < nums.Length; i++)
				nums[i] += nums[i - 1];

			return nums;
		}
	}
}
