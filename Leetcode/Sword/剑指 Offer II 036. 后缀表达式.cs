/*
 * Author: Deean
 * Date: 2023-05-23 23:06:12
 * FileName: 剑指 Offer II 036. 后缀表达式.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_036__后缀表达式 {
    public class Solution {
        public int EvalRPN(string[] tokens) {
            Stack<int> stack = new Stack<int>();
            foreach (var token in tokens) {
                if ((token.Length > 1 && token[0] == '-') || (token[0] >= '0' && token[0] <= '9')) {
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