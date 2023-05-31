/*
 * Author: Deean
 * Date: 2023-05-31 23:56:31
 * FileName: 面试题 02.08. 环路检测.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Interview; 

public class 面试题_02_08__环路检测 {
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
        var head = new ListNode("[3,2,0,-4]");
        var s = new Solution();
        var ans = s.DetectCycle(head);
        Console.WriteLine(ans);
    }
}