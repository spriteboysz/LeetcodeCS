/*
 * Author: Deean
 * Date: 2023-04-04 12:28:19
 * FileName: P0728.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0728 {
    public class Solution {
        public IList<int> SelfDividingNumbers(int left, int right) {
            IList<int> nums = new List<int>();
            for (int i = left; i <= right; i++) {
                int flag = 1, num = i;
                while (num > 0) {
                    int digit = num % 10;
                    if (digit == 0 || i % digit != 0) {
                        flag = 0;
                        break;
                    }
                    num /= 10;
                }
                if (flag == 1) nums.Add(i);
            }
            return nums;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SelfDividingNumbers(47, 85);
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}