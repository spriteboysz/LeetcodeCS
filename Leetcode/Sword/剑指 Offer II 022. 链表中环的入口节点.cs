/*
 * Author: Deean
 * Date: 2023-05-21 22:05:12
 * FileName: 剑指 Offer II 022. 链表中环的入口节点.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_022__链表中环的入口节点 {
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