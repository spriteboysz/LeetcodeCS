/*
 * Author: Deean
 * Date: 2023-04-09 10:07:39
 * FileName: 面试题 10.05. 稀疏数组搜索.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_10_05__稀疏数组搜索 {
    public class Solution {
        public int FindString(string[] words, string s) {
            int left = 0, right = words.Length - 1;
            while (left <= right) {
                if (Equals(words[left], "")) {
                    left++;
                    continue;
                }
                if (Equals(words[right], "")) {
                    right--;
                    continue;
                }
                int mid = left + (right - left) / 2;
                while (mid < right && Equals(words[mid], "")) {
                    if (++mid == right) {
                        right = (left + right) / 2;
                        break;
                    }
                }
                if (String.CompareOrdinal(words[mid], s) == 0) {
                    return mid;
                }
                if (String.CompareOrdinal(words[mid], s) > 0) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindString(new[] { "at", "", "", "", "ball", "", "", "car", "", "", "dad", "", "" }, "at");
        Console.WriteLine(ans);
    }
}