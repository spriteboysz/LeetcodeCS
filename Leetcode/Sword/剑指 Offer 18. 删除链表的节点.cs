/*
 * Author: Deean
 * Date: 2023-04-08 13:34:01
 * FileName: 剑指 Offer 18. 删除链表的节点.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_18__删除链表的节点 {
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