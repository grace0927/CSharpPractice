using System;

namespace CSharpPractice
{
	public class FirstMissingPositiveSol
	{
		public FirstMissingPositiveSol ()
		{
		}

		public int FirstMissingPositive(int[] nums) {
			int len = nums.Length;
			for(int i=0; i<len; i++) {
				int cur = nums[i];
				while(cur>0 && cur<=len && cur!=nums[cur-1]) {
					Swap(nums, i, cur-1);
					cur = nums[i];
				}
				nums[i] = cur;
			}

			for(int i=0; i<len; i++) {
				if(nums[i]!=i+1) {
					return i+1;
				}
			}

			return len+1;
		}

		private void Swap(int[] nums, int i, int j) {
			if(i<0 || i>=nums.Length || j<0 || j>=nums.Length) {
				return ;
			}
			int tmp = nums[i];
			nums[i] = nums[j];
			nums[j] = tmp;
		}
	}
}