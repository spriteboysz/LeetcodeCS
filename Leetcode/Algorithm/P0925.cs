/*
 * Author: Deean
 * Date: 2023-04-03 23:27:13
 * FileName: P0925.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0925 {
    public class Solution {
        public bool IsLongPressedName(string name, string typed) {
            int i = 0, j = 0;
            while (j < typed.Length) {
                if (i < name.Length && name[i] == typed[j]) {
                    i++;
                    j++;
                } else if (j > 0 && typed[j] == typed[j - 1]) {
                    j++;
                } else {
                    return false;
                }
            }
            return i == name.Length;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsLongPressedName("alex", "aaleex");
        Console.WriteLine(ans);
    }
}