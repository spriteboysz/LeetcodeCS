/*
 * Author: Deean
 * Date: 2023-03-19 12:04:02
 * FileName: P2264.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P2264 {
    public class Solution {
        public string LargestGoodInteger(string num) {
            for (int i = 10 - 1; i >= 0; i--) {
                string ss = string.Format("{0:D3}", i * 111);
                if (num.Contains(ss)) {
                    return ss;
                }
            }
            return "";
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargestGoodInteger("6777133339");
        Console.WriteLine(ans);
    }
}