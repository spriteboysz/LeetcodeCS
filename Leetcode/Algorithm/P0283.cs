/*
 * Author: Deean
 * Date: 2023-04-06 23:38:06
 * FileName: P0283.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0283 {
    public class Solution {
        public void MoveZeroes(int[] nums) {
            int fast = 0, slow = 0;
            while (fast < nums.Length) {
                if (nums[fast] != 0) {
                    int temp = nums[fast];
                    nums[fast] = nums[slow];
                    nums[slow] = temp;
                    slow++;
                }
                fast++;
            }
            Console.WriteLine(lib.Arrays.ToString(nums));
        } 
    }

    public static void Test() {
        var s = new Solution();
        s.MoveZeroes(new []{0,1,0,3,12});
    }
}