/*
 * Author: Deean
 * Date: 2023-05-20 15:12:31
 * FileName: P2656.cs
 * Description:
*/

using System.Linq;

namespace Algorithm;

public class P2656 {
    public class Solution {
        public int MaximizeSum(int[] nums, int k) {
            return (nums.Max() * 2 + k - 1) * k / 2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaximizeSum(new[] { 1, 2, 3, 4, 5 }, 3);
        System.Console.WriteLine(ans);
    }
}