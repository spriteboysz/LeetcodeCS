/*
 * Author: Deean
 * Date: 2023-06-03 16:51:48
 * FileName: P2095.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm; 

public class P2095 {
    public class Solution {
        public ListNode DeleteMiddle(ListNode head) {
            if (head.next == null) return null;
            ListNode fast = head, slow = head;
            ListNode pre = null;
            while (fast != null && fast.next != null) {
                fast = fast.next.next;
                pre = slow;
                slow = slow.next;
            }
            pre.next = pre.next.next;
            return head;
        } 
    }

    public static void Test() {
        var head = new ListNode("[1,3,4,7,1,2,6]");
        var s = new Solution();
        var ans = s.DeleteMiddle(head);
        Console.WriteLine(ans);
    }
}