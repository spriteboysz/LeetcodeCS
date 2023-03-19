/*
 * Author: Deean
 * Date: 2023-03-18 22:39:44
 * FileName: P2423.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2423 {
    public class Solution {
        public bool EqualFrequency(string word) {
            int maxCnt = 0, minCnt = 0;
            int minNum = int.MaxValue, maxNum = int.MinValue;
            int[] alphabet = new int[26];
            foreach (var c in word) {
                alphabet[c - 'a']++;
            }
            foreach (var c in alphabet) {
                if (c == 0) continue;
                maxNum = Math.Max(maxNum, c);
                minNum = Math.Min(minNum, c);
            }
            foreach (var c in alphabet) {
                if (c == 0) continue;
                if (c == maxNum) maxCnt++;
                else if (c == minNum) minCnt++;
                else return false;
            }
            return maxCnt == 1 && (maxNum - minNum == 1) || maxNum == 1 || (minCnt == 1 && minNum == 1) ||
                   maxCnt == 1 && minCnt == 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.EqualFrequency("abcc");
        Console.WriteLine(ans);
    }
}