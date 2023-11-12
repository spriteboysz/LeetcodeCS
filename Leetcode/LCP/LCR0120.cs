/*
 * Author: Deean
 * Date: 2023-11-11 09:54:13
 * FileName: LCR0120.cs
 * Description: LCR 120. 寻找文件副本
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0120 {
    public class Solution {
        public int FindRepeatDocument(int[] documents) {
            HashSet<int> seen = new HashSet<int>();
            foreach (var document in documents) {
                if (seen.Contains(document)) {
                    return document;
                }
                seen.Add(document);
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindRepeatDocument(new[] { 2, 5, 3, 0, 5, 0 });
        Console.WriteLine(ans);
    }
}