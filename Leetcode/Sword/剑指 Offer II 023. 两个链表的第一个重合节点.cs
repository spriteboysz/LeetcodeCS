/*
 * Author: Deean
 * Date: 2023-04-08 17:32:40
 * FileName: 剑指 Offer II 023. 两个链表的第一个重合节点.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_023__两个链表的第一个重合节点 {
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
        var ans = s.GetIntersectionNode(new ListNode("[4,1,8,4,5]"), new ListNode("[5,0,1,8,4,5]"));
        Console.WriteLine(ans);
    }
}