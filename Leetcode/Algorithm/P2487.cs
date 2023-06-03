/*
 * Author: Deean
 * Date: 2023-06-02 23:24:43
 * FileName: P2487.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P2487 {
    public class Solution {
        public ListNode RemoveNodes(ListNode head) {
            IList<ListNode> nodes1 = new List<ListNode>();
            while (head != null) {
                nodes1.Add(head);
                head = head.next;
            }
            IList<ListNode> nodes2 = new List<ListNode>();
            nodes2.Add(nodes1.Last());

            for (int i = nodes1.Count - 2; i >= 0; i--) {
                if (nodes1[i].val >= nodes2.Last().val) {
                    nodes2.Add(nodes1[i]);
                }
            }
            for (int i = nodes2.Count - 1; i >= 1; i--) {
                nodes2[i].next = nodes2[i - 1];
            }
            nodes2[0].next = null;
            return nodes2[nodes2.Count - 1];
        }
    }

    public static void Test() {
        var head = new ListNode("[5,2,13,3,8]");
        var s = new Solution();
        var ans = s.RemoveNodes(head);
        Console.WriteLine(ans);
    }
}