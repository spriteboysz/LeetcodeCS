/*
 * Author: Deean
 * Date: 2023-11-20 22:51:58
 * FileName: LCR0136.cs
 * Description: LCR 136. 删除链表的节点
 */

using System;
using lib;

namespace LCP;

public class LCR0136 {
    public class Solution {
        public ListNode DeleteNode(ListNode head, int val) {
            if (head == null) return null;
            if (head.val == val) return head.next;
            ListNode cur = head;
            while (cur != null || cur.next != null) {
                if (cur.next.val == val) {
                    cur.next = cur.next.next;
                    break;
                }
                cur = cur.next;
            }
            return head;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DeleteNode(new ListNode("[4,5,1,9]"), 5);
        Console.WriteLine(ans);
    }
}