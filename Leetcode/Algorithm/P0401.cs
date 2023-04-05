/*
 * Author: Deean
 * Date: 2023-04-05 22:22:19
 * FileName: P0401.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0401 {
    public class Solution {
        private int Process(int num) {
            int cnt = 0;
            while (num > 0) {
                cnt += num & 1;
                num >>= 1;
            }
            return cnt;
        }

        public IList<string> ReadBinaryWatch(int turnedOn) {
            IList<string> time = new List<string>();
            for (int i = 0; i < 12 * 60; i++) {
                int hh = i / 60, mm = i % 60;
                if (Process(hh) + Process(mm) == turnedOn) {
                    time.Add($"{hh}:{mm,1:D2}");
                }
            }
            return time;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReadBinaryWatch(1);
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}