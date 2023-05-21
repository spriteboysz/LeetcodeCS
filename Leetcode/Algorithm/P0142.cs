/*
 * Author: Deean
 * Date: 2023-05-21 22:09:02
 * FileName: P0142.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0142 {
    public class Solution {
        public ListNode DetectCycle(ListNode head) {
            var visited = new HashSet<ListNode>();
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