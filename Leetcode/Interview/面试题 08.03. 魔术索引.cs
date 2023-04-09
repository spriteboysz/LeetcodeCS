/*
 * Author: Deean
 * Date: 2023-04-09 11:47:42
 * FileName: 面试题 08.03. 魔术索引.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_08_03__魔术索引 {
    public class Solution {
        public int FindMagicIndex(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                if (i == nums[i]) {
                    return i;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindMagicIndex(new[] { 1, 1, 1 });
        Console.WriteLine(ans);
    }
}