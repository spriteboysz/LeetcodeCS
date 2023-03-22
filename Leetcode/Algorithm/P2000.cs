/*
 * Author: Deean
 * Date: 2023-03-22 22:38:28
 * FileName: P2000.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2000 {
    public class Solution {
        public string ReversePrefix(string word, char ch) {
            int index = word.IndexOf(ch);
            if (index < 0) return word;
            char[] chars = word.ToCharArray();
            int left = 0, right = index;
            while (left < right) {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
            return new string(chars);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReversePrefix("abcdefd", 'd');
        Console.WriteLine(ans);
    }
}