/*
 * Author: Deean
 * Date: 2023-05-21 22:20:59
 * FileName: P0445.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0445 {
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            Stack<int> s1 = new Stack<int>(), s2 = new Stack<int>();
            while (l1 != null) {
                s1.Push(l1.val);
                l1 = l1.next;
            }
            while (l2 != null) {
                s2.Push(l2.val);
                l2 = l2.next;
            }
            int carry = 0;
            ListNode sum = null;
            while (s1.Count > 0 || s2.Count > 0 || carry != 0) {
                carry += s1.Count == 0 ? 0 : s1.Pop();
                carry += s2.Count == 0 ? 0 : s2.Pop();
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
        ListNode l1 = new ListNode("[7,2,4,3]");
        ListNode l2 = new ListNode("[5,6,4]");
        var ans = s.AddTwoNumbers(l1, l2);
        Console.WriteLine(ans);
    }
}