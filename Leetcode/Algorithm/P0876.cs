/*
 * Author: Deean
 * Date: 2023-04-02 21:57:11
 * FileName: P0876.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0876 {
    public class Solution {
        public ListNode MiddleNode(ListNode head) {
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null) {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MiddleNode(new ListNode("[1,2,3,4,5]"));
        Console.WriteLine(ans.ToString());
        ans = s.MiddleNode(new ListNode("[1,2,3,4,5,6]"));
        Console.WriteLine(ans.ToString());
    }
}