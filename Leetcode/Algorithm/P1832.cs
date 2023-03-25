/*
 * Author: Deean
 * Date: 2023-03-25 21:28:49
 * FileName: P1832.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1832 {
    public class Solution {
        public bool CheckIfPangram(string sentence) {
            HashSet<char> set = new HashSet<char>();
            foreach (var c in sentence) {
                set.Add(c);
            }
            return set.Count == 26;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckIfPangram("thequickbrownfoxjumpsoverthelazydog");
        Console.WriteLine(ans);
    }
}