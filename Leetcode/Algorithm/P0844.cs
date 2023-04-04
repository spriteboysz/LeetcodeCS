/*
 * Author: Deean
 * Date: 2023-04-04 09:15:10
 * FileName: P0844.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0844 {
    public class Solution {
        private string Process(string s) {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s) {
                if (c != '#') {
                    stack.Push(c);
                } else if (c == '#' && stack.Count > 0) {
                    stack.Pop();
                }
            }
            return new string(stack.ToArray());
        }

        public bool BackspaceCompare(string s, string t) {
            return Equals(Process(s), Process(t));
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.BackspaceCompare("ab##", "c#d#");
        Console.WriteLine(ans);
    }
}