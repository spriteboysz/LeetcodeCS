/*
 * Author: Deean
 * Date: 2023-04-07 23:08:35
 * FileName: P0203.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0203 {
    public class Solution {
        public ListNode RemoveElements(ListNode head, int val) {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode temp = dummy;
            while (temp.next != null) {
                if (temp.next.val == val) {
                    temp.next = temp.next.next;
                } else {
                    temp = temp.next;
                }
            }
            return dummy.next;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveElements(new ListNode("[1,2,6,3,4,5,6]"), 6);
        Console.WriteLine(ans);
    }
}