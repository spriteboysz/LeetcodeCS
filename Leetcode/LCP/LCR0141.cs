/*
 * Author: Deean
 * Date: 2023-11-23 22:51:35
 * FileName: LCR0141.cs
 * Description: LCR 141. 训练计划 III
*/

using System;
using System.Collections.Generic;
using lib;

namespace LCP; 

public class LCR0141 {
    public class Solution {
        public ListNode TrainningPlan(ListNode head) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            for (int i = nodes.Count - 1; i >= 1; i--) {
                nodes[i].next = nodes[i - 1];
            }
            nodes[0].next = null;
            return nodes[nodes.Count - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TrainningPlan(new ListNode("[1,2,3,4,5]"));
        Console.WriteLine(ans);
    }
}