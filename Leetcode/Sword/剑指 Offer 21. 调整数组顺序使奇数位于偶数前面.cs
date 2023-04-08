/*
 * Author: Deean
 * Date: 2023-04-08 13:43:15
 * FileName: 剑指 Offer 21. 调整数组顺序使奇数位于偶数前面.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Sword; 

public class 剑指_Offer_21__调整数组顺序使奇数位于偶数前面 {
    public class Solution {
        public int[] Exchange(int[] nums) {
            IList<int> odd = new List<int>(), even = new List<int>();
            foreach (var num in nums) {
                if (num % 2 == 0) {
                    even.Add(num);
                } else {
                    odd.Add(num);
                }
            }
            return odd.Concat(even).ToArray();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Exchange(new[]{1,2,3,4});
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}