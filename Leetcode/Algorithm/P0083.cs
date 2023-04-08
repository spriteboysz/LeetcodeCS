/*
 * Author: Deean
 * Date: 2023-04-08 10:33:16
 * FileName: P0083.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0083 {
    public class Solution {
        public ListNode DeleteDuplicates(ListNode head) {
            if (head == null) return null;
            if (head.next == null) return head;
            if (head.val == head.next.val) {
                head = DeleteDuplicates(head.next);
            } else {
                head.next = DeleteDuplicates(head.next);
            }
            return head;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DeleteDuplicates(new ListNode("[1,1,2,3,3]"));
        Console.WriteLine(ans);
    }
}