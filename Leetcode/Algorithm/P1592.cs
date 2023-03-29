/*
 * Author: Deean
 * Date: 2023-03-29 21:58:46
 * FileName: P1592.cs
 * Description:
*/

using System;
using System.Linq;
using System.Text;

namespace Algorithm;

public class P1592 {
    public class Solution {
        public string ReorderSpaces(string text) {
            string[] words = text.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = text.Length;
            int num = words.Length;
            int m = words.Sum(word => word.Length);
            if (m == n) return text;
            int mod = n - m, div = 1;
            if (num != 1) {
                div = (n - m) / (num - 1);
                mod = (n - m) % (num - 1);
            }
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < num; i++) {
                ss.Append(words[i]);
                if (i != words.Length - 1) {
                    ss.Append(' ', div);
                }
            }
            ss.Append(' ', mod);
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReorderSpaces(" practice   makes   perfect");
        Console.WriteLine(ans);
    }
}