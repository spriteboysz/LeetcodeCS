/*
 * Author: Deean
 * Date: 2023-04-09 10:52:07
 * FileName: 面试题 02.07. 链表相交.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Interview;

public class 面试题_02_07__链表相交 {
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
                seen.Add(headB);
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