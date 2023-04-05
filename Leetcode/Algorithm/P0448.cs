/*
 * Author: Deean
 * Date: 2023-04-05 19:29:53
 * FileName: P0448.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0448 {
    public class Solution {
        public IList<int> FindDisappearedNumbers(int[] nums) {
            int n = nums.Length;
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums) {
                set.Add(num);
            }
            IList<int> disappeared = new List<int>();
            for (int i = 1; i <= n; i++) {
                if (!set.Contains(i)) {
                    disappeared.Add(i);
                }
            }
            return disappeared;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindDisappearedNumbers(new[]{4,3,2,7,8,2,3,1});
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}