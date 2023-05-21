/*
 * Author: Deean
 * Date: 2023-05-21 22:01:39
 * FileName: P0019.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0019 {
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