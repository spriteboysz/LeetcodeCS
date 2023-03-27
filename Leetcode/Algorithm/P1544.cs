/*
 * Author: Deean
 * Date: 2023-03-27 23:59:36
 * FileName: P1544.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P1544 {
    public class Solution {
        public string MakeGood(string s) {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s) {
                if (stack.Count == 0) {
                    stack.Push(c);
                } else if (Math.Abs(stack.Peek() - c) == 32) {
                    stack.Pop();
                } else {
                    stack.Push(c);
                }
            }
            return new string(stack.Reverse().ToArray());
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MakeGood("leEeetcode");
        Console.WriteLine(ans);
    }
}