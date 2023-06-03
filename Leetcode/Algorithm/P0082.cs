/*
 * Author: Deean
 * Date: 2023-06-03 11:09:10
 * FileName: P0082.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0082 {
    public class Solution {
        public ListNode DeleteDuplicates(ListNode head) {
            if (head == null) return null;
            IDictionary<int, int> dict = new Dictionary<int, int>();
            var cur = head;
            while (cur != null) {
                if (!dict.ContainsKey(cur.val)) {
                    dict[cur.val] = 0;
                }
                dict[cur.val] += 1;
                cur = cur.next;
            }

            IList<ListNode> nodes = new List<ListNode>();
            cur = head;
            while (cur != null) {
                if (dict[cur.val] == 1) {
                    nodes.Add(cur);
                }
                cur = cur.next;
            }
            int n = nodes.Count;
            if (n == 0) return null;
            for (int i = 0; i < n - 1; i++) {
                nodes[i].next = nodes[i + 1];
            }
            nodes.Last().next = null;
            return nodes.First();
        }
    }

    public static void Test() {
        var head = new ListNode("[1,2,3,3,4,4,5]");
        var s = new Solution();
        var ans = s.DeleteDuplicates(head);
        Console.WriteLine(ans);
    }
}