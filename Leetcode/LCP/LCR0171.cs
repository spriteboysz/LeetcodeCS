/*
 * Author: Deean
 * Date: 2023-12-10 09:48:46
 * FileName: LCR0171.cs
 * Description: LCR 171. 训练计划 V
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0171 {
    public class Solution {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
            HashSet<ListNode> seen = new HashSet<ListNode>();
            while (headA != null) {
                seen.Add(headA);
                headA = headA.next;
            }
            while (headB != null) {
                if (seen.Contains(headB)) {
                    return headB;
                }
                headB = headB.next;
            }
            return null;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetIntersectionNode(new ListNode("[3,7,2,8,9,5,1]"), new ListNode("[4,6,8,9,5,1]"));
        Console.WriteLine(ans);
    }
}