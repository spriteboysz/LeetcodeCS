/*
 * Author: Deean
 * Date: 2023-10-20 23:50:43
 * FileName: LCR0021.cs
 * Description: LCR 021. 删除链表的倒数第 N 个结点
 */

using System;
using lib;

namespace LCP;

public class LCR0021 {
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
        var head = new ListNode("[1,2,3,4,5]");
        var s = new Solution();
        var ans = s.RemoveNthFromEnd(head, 2);
        Console.WriteLine(ans.ToString());
    }
}