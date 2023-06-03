/*
 * Author: Deean
 * Date: 2023-06-03 15:57:48
 * FileName: P2181.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P2181 {
    public class Solution {
        public ListNode mergeNodes(ListNode head) {
            var dummy = new ListNode();
            var cur = dummy;
            head = head.next;
            int sum = 0;
            while (head != null) {
                if (head.val == 0) {
                    cur.next = new ListNode(sum);
                    cur = cur.next;
                    sum = 0;
                } else {
                    sum += head.val;
                }
                head = head.next;
            }
            return dummy.next;
        }
    }

    public static void Test() {
        var head = new ListNode("[0,3,1,0,4,5,2,0]");
        var s = new Solution();
        var ans = s.mergeNodes(head);
        Console.WriteLine(ans);
    }
}