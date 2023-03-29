/*
 * Author: Deean
 * Date: 2023-03-29 23:23:06
 * FileName: P1403.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P1403 {
    public class Solution {
        public IList<int> MinSubsequence(int[] nums) {
            Array.Sort(nums, (a, b) => b - a);
            int sum = nums.Sum(), acc = 0;
            IList<int> sequence = new List<int>();
            foreach (var num in nums) {
                if (acc > sum - acc) break;
                acc += num;
                sequence.Add(num);
            }
            return sequence;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinSubsequence(new []{4,4,7,6,7});
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}