/*
 * Author: Deean
 * Date: 2023-04-08 13:29:20
 * FileName: 剑指 Offer 17. 打印从1到最大的n位数.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Sword;

public class 剑指_Offer_17__打印从1到最大的n位数 {
    public class Solution {
        public int[] PrintNumbers(int n) {
            IList<int> list = new List<int>();
            for (int i = 1; i < Math.Pow(10, n); i++) {
                list.Add(i);
            }
            return list.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PrintNumbers(2);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}