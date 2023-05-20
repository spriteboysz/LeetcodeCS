/*
 * Author: Deean
 * Date: 2023-05-19 22:31:23
 * FileName: P2600.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2600 {
    public class Solution {
        public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k) {
            IList<int> nums = new List<int>();
            for (int i = 0; i < numOnes; i++) {
                nums.Add(1);
            }
            for (int i = 0; i < numZeros; i++) {
                nums.Add(0);
            }
            for (int i = 0; i < numNegOnes; i++) {
                nums.Add(-1);
            }
            int sum = 0;
            for (int i = 0; i < k; i++) {
                sum += nums[i];
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.KItemsWithMaximumSum(3, 2, 0, 2);
        Console.WriteLine(ans);
    }
}