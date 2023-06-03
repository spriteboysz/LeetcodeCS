/*
 * Author: Deean
 * Date: 2023-06-02 22:49:59
 * FileName: P0147.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0147 {
    public class Solution {
        public ListNode InsertionSortList(ListNode head) {
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            ListNode[] list = nodes.ToArray();
            Array.Sort(list, (a, b) => a.val - b.val);
            for (int i = 0, n = list.Length; i < n - 1; i++) {
                list[i].next = list[i + 1];
            }
            list[list.Length - 1].next = null;
            return list[0];
        }
    }

    public static void Test() {
        var head = new ListNode("[4,2,1,3]");
        var s = new Solution();
        var ans = s.InsertionSortList(head);
        Console.WriteLine(ans);
    }
}