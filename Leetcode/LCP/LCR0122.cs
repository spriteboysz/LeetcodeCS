/*
 * Author: Deean
 * Date: 2023-11-12 09:30:20
 * FileName: LCR0122.cs
 * Description: LCR 122. 路径加密
 */

using System;

namespace LCP;

public class LCR0122 {
    public class Solution {
        public string PathEncryption(string path) {
            return path.Replace(".", " ");
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PathEncryption("a.aef.qerf.bb");
        Console.WriteLine(ans);
    }
}