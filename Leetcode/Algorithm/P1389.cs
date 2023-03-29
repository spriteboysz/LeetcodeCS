/*
 * Author: Deean
 * Date: 2023-03-29 23:43:17
 * FileName: P1389.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P1389 {
    public class Solution {
        public int[] CreateTargetArray(int[] nums, int[] index) {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                list.Insert(index[i], nums[i]);
            }
            return list.ToArray();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CreateTargetArray(new[]{0,1,2,3,4}, new[]{0,1,2,2,1});
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}