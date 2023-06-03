/*
 * Author: Deean
 * Date: 2023-06-03 18:00:42
 * FileName: P0002.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0002 {
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            Queue<int> s1 = new Queue<int>(), s2 = new Queue<int>();
            while (l1 != null) {
                s1.Enqueue(l1.val);
                l1 = l1.next;
            }
            while (l2 != null) {
                s2.Enqueue(l2.val);
                l2 = l2.next;
            }
            int carry = 0;
            var dummy = new ListNode();
            var cur = dummy;
            while (s1.Count != 0 || s2.Count != 0 || carry != 0) {
                if (s1.Count != 0) carry += s1.Dequeue();
                if (s2.Count != 0) carry += s2.Dequeue();
                cur.next = new ListNode(carry % 10);
                cur = cur.next;
                carry /= 10;
            }
            return dummy.next;
        }
    }

    public static void Test() {
        var l1 = new ListNode("[2,4,3]");
        var l2 = new ListNode("[5,6,4]");
        var s = new Solution();
        var ans = s.AddTwoNumbers(l1, l2);
        Console.WriteLine(ans);
    }
}