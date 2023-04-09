/*
 * Author: Deean
 * Date: 2023-04-08 20:32:26
 * FileName: 面试题 01.06. 字符串压缩.cs
 * Description:
*/

using System;
using System.Text;

namespace Interview;

public class 面试题_01_06__字符串压缩 {
    public class Solution {
        public string CompressString(string S) {
            if (S == "") return S;
            StringBuilder ss = new StringBuilder();
            int cnt = 1;
            char last = S[0];
            for (int i = 1, n = S.Length; i < n; i++) {
                if (last != S[i]) {
                    ss.Append(last).Append(cnt);
                    cnt = 1;
                    last = S[i];
                } else {
                    cnt++;
                }
            }
            string compress = ss.Append(last).Append(cnt).ToString();
            return compress.Length < S.Length ? compress : S;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CompressString("aabcccccaaa");
        Console.WriteLine(ans);
    }
}