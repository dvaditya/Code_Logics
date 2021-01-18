using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class MoveZeroesToMiddle
    {
        public int[] moveZeroesToMiddle(int[] nums)
        {
            int indexS = 0;
            int indexE = nums.Length - 1;
            for (int i = nums.Length - 1; i > nums.Length / 2 - 1; i--)
            {
                if (nums[i] != 0) nums[indexE--] = nums[i];
            }
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] != 0) nums[indexS++] = nums[i];
            }
            for (int i = indexS; i <= indexE; i++) nums[i] = 0;
            return nums;
        }

        public static int[] MoveZeroes(int[] nums)
        {
            int count = nums.Length / 2;
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] != 0)
                {
                    nums[count++] = nums[i];
                }
            }

            for (int j = count; j < len; j++)
            {
                nums[count++] = 0;
            }

            return nums;
        }
    }
}
