/*
 * Author: Deean
 * Date: 2023-06-02 22:38:02
 * FileName: P2130.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P2130 {
    public class Solution {
        public int PairSum(ListNode head) {
            IList<int> values = new List<int>();
            while (head != null) {
                values.Add(head.val);
                head = head.next;
            }
            int maximum = 0;
            for (int i = 0, n = values.Count; i < n / 2; i++) {
                maximum = Math.Max(maximum, values[i] + values[n - 1 - i]);
            }
            return maximum;
        }
    }

    public static void Test() {
        var head = new ListNode("[5,4,2,1]");
        var s = new Solution();
        var ans = s.PairSum(head);
        Console.WriteLine(ans);
    }
}