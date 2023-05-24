/*
 * Author: Deean
 * Date: 2023-05-23 23:21:48
 * FileName: P0150.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0150 {
    public class Solution {
        public int EvalRPN(string[] tokens) {
            Stack<int> stack = new Stack<int>();
            foreach (var token in tokens) {
                if (token.Last() >= '0' && token.Last() <= '9') {
                    stack.Push(Int32.Parse(token));
                } else {
                    int a = stack.Pop(), b = stack.Pop();
                    switch (token) {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(b - a);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            stack.Push(b / a);
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.EvalRPN(new[] { "2", "1", "+", "3", "*" });
        Console.WriteLine(ans);
    }
}