/*
 * Author: Deean
 * Date: 2023-03-31 23:25:29
 * FileName: P1078.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P1078 {
    public class Solution {
        public string[] FindOcurrences(string text, string first, string second) {
            string[] words = text.Split(' ');
            int n = words.Length;
            List<String> list = new List<string>();
            for (int i = 2; i < n; i++) {
                if (Equals(words[i - 2], first) && Equals(words[i - 1], second)) {
                    list.Add(words[i]);
                }
            }
            return list.ToArray();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindOcurrences("alice is a good girl she is a good student", "a", "good");
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}