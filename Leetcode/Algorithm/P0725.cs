/*
 * Author: Deean
 * Date: 2023-06-01 23:36:11
 * FileName: P0725.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0725 {
    public class Solution {
        public ListNode[] SplitListToParts(ListNode head, int k) {
            int n = 0;
            ListNode cur = head;
            while (cur != null) {
                n++;
                cur = cur.next;
            }
            int quotient = n / k, remainder = n % k;
            ListNode[] parts = new ListNode[k];
            cur = head;
            for (int i = 0; i < k && cur != null; i++) {
                parts[i] = cur;
                int size = quotient + (i < remainder ? 1 : 0);
                for (int j = 1; j < size; j++) {
                    cur = cur.next;
                }
                ListNode next = cur.next;
                cur.next = null;
                cur = next;
            }
            return parts;
        }
    }

    public static void Test() {
        var head = new ListNode("[1,2,3,4,5,6,7,8,9,10]");
        var s = new Solution();
        var ans = s.SplitListToParts(head, 3);
        Console.WriteLine(ans);
    }
}