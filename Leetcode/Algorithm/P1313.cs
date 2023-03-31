/*
 * Author: Deean
 * Date: 2023-03-31 21:31:48
 * FileName: P1313.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P1313 {
    public class Solution {
        public int[] DecompressRLElist(int[] nums) {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i += 2) {
                for (int j = 0; j < nums[i]; j++) {
                    list.Add(nums[i + 1]);
                }
            }
            return list.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DecompressRLElist(new[]{ 1,2,3,4});
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}