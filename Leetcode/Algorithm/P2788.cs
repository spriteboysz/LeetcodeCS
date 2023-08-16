/*
 * Author: Deean
 * Date: 2023-08-16 22:13:24
 * FileName: P2788.cs
 * Description:2788. 按分隔符拆分字符串
 */

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2788 {
    public class Solution {
        public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
            IList<string> ss = new List<string>();
            foreach (var word in words) {
                foreach (var w in word.Split(separator)) {
                    if (w != "") {
                        ss.Add(w);
                    }
                }
            }
            return ss;
        }
    }

    public static void Test() {
        var s = new Solution();
        IList<string> words = new List<string> { "one.two.three", "four.five", "six" };
        var ans = s.SplitWordsBySeparator(words, '.');
        Console.WriteLine(ans);
    }
}