/*
 * Author: Deean
 * Date: 2023-04-08 09:22:41
 * FileName: P0141.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm; 

public class P0141 {
    public class Solution {
        public bool HasCycle(ListNode head) {
            HashSet<ListNode> seen = new HashSet<ListNode>();
            while (head != null) {
                if (seen.Contains(head)) {
                    return true;
                }
                seen.Add(head);
                head = head.next;
            }
            return false;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.HasCycle(new ListNode("[3,2,0,-4]"));
        Console.WriteLine(ans);
    }
}