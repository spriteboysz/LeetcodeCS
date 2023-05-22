/*
 * Author: Deean
 * Date: 2023-05-21 21:55:37
 * FileName: 剑指 Offer II 021. 删除链表的倒数第 n 个结点.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_II_021__删除链表的倒数第_n_个结点 {
    public class Solution {
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            var dummy = new ListNode(0, head);
            ListNode fast = dummy, slow = dummy;
            for (int i = 0; i < n; i++) {
                fast = fast.next;
            }
            while (fast.next != null) {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return dummy.next;
        }
    }

    public static void Test() {
        var s = new Solution();
        var head = new ListNode("[1,2,3,4,5]");
        var ans = s.RemoveNthFromEnd(head, 2);
        Console.WriteLine(ans);
    }
}