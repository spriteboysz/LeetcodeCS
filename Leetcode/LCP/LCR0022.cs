/*
 * Author: Deean
 * Date: 2023-10-21 13:33:45
 * FileName: LCR0022.cs
 * Description: LCR 022. 环形链表 II
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0022 {
    public class Solution {
        public ListNode DetectCycle(ListNode head) {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            while (head != null) {
                if (visited.Contains(head)) {
                    return head;
                }
                visited.Add(head);
                head = head.next;
            }
            return null;
        }
    }

    public static void Test() {
        var s = new Solution();
        var head = new ListNode("[3,2,0,-4]");
        var ans = s.DetectCycle(head);
        Console.WriteLine(ans);
    }
}