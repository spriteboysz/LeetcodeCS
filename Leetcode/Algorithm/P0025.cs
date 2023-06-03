/*
 * Author: Deean
 * Date: 2023-06-02 23:05:48
 * FileName: P0025.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0025 {
    public class Solution {
        public ListNode ReverseKGroup(ListNode head, int k) {
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            ListNode[] list = nodes.ToArray();
            for (int i = 0, n = list.Length; i + k <= n; i += k) {
                for (int j = 0; j < k / 2; j++) {
                    ListNode node = list[i + j];
                    list[i + j] = list[i + k - j - 1];
                    list[i + k - j - 1] = node;
                }
            }
            for (int i = 0, n = list.Length; i < n - 1; i++) {
                list[i].next = list[i + 1];
            }
            list[list.Length - 1].next = null;
            return list[0];
        }
    }

    public static void Test() {
        var head = new ListNode("[1,2,3,4]");
        var s = new Solution();
        var ans = s.ReverseKGroup(head, 4);
        Console.WriteLine(ans);
    }
}