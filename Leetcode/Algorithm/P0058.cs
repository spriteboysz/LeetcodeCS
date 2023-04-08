/*
 * Author: Deean
 * Date: 2023-04-08 11:04:45
 * FileName: P0058.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0058 {
    public class Solution {
        public int LengthOfLastWord(string s) {
            int index = s.Length - 1;
            while (s[index] == ' ') {
                index--;
            }
            int len = 0;
            while (index >= 0 && s[index--] != ' ') {
                len++;
            }
            return len;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LengthOfLastWord("   fly me   to   the moon  ");
        Console.WriteLine(ans);
    }
}