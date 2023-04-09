/*
 * Author: Deean
 * Date: 2023-04-09 10:26:57
 * FileName: 面试题 02.01. 移除重复节点.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Interview;

public class 面试题_02_01__移除重复节点 {
    public class Solution {
        public ListNode RemoveDuplicateNodes(ListNode head) {
            if (head == null || head.next == null) return head;
            HashSet<int> seen = new HashSet<int> { head.val };
            ListNode first = head, second = head.next;
            while (second != null) {
                if (seen.Contains(second.val)) {
                    first.next = second.next;
                    if (first.next == null) break;
                    second = first.next;
                    continue;
                }
                first = second;
                seen.Add(second.val);
                second = second.next;
            }
            return head;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveDuplicateNodes(new ListNode("[1, 2, 3, 3, 2, 1]"));
        Console.WriteLine(ans);
    }
}