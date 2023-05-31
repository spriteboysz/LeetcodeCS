/*
 * Author: Deean
 * Date: 2023-05-31 23:31:49
 * FileName: 面试题 02.05. 链表求和.cs
 * Description:
*/

using System;
using lib;

namespace Interview;

public class 面试题_02_05__链表求和 {
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode dummy = new ListNode();
            ListNode cur = dummy;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0) {
                if (l1 != null) {
                    carry += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null) {
                    carry += l2.val;
                    l2 = l2.next;
                }
                ListNode node = new ListNode(carry % 10);
                cur.next = node;
                cur = cur.next;
                carry /= 10;
            }
            return dummy.next;
        }
    }

    public static void Test() {
        var l1 = new ListNode("[7,1,6]");
        var l2 = new ListNode("[5,9,2]");
        var s = new Solution();
        var ans = s.AddTwoNumbers(l1, l2);
        Console.WriteLine(ans);
    }
}