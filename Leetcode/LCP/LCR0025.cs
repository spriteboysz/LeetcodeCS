/*
 * Author: Deean
 * Date: 2023-10-21 14:38:12
 * FileName: LCR0025.cs
 * Description: LCR 025. 两数相加 II
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0025 {
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            Stack<int> stack1 = new Stack<int>(), stack2 = new Stack<int>();
            while (l1 != null) {
                stack1.Push(l1.val);
                l1 = l1.next;
            }
            while (l2 != null) {
                stack2.Push(l2.val);
                l2 = l2.next;
            }
            int carry = 0;
            ListNode sum = null;
            while (stack1.Count > 0 || stack2.Count > 0 || carry != 0) {
                carry += stack1.Count == 0 ? 0 : stack1.Pop();
                carry += stack2.Count == 0 ? 0 : stack2.Pop();
                ListNode cur = new ListNode(carry % 10) {
                    next = sum
                };
                sum = cur;
                carry /= 10;
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var l1 = new ListNode("[7,2,4,3]");
        var l2 = new ListNode("[5,6,4]");
        var ans = s.AddTwoNumbers(l1, l2);
        Console.WriteLine(ans.ToString());
    }
}