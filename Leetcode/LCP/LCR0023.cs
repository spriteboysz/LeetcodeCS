/*
 * Author: Deean
 * Date: 2023-10-21 13:35:58
 * FileName: LCR0023.cs
 * Description: LCR 023. 相交链表
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0023 {
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
        var headA = new ListNode("[4,1,8,4,5]");
        var headB = new ListNode("[4,1,8,4,5]");
        var s = new Solution();
        var ans = s.GetIntersectionNode(headA, headB);
        Console.WriteLine(ans);
    }
}