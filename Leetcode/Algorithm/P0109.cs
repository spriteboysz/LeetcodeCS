/*
 * Author: Deean
 * Date: 2023-06-02 23:41:26
 * FileName: P0109.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0109 {
    public class Solution {
        private TreeNode create(int[] nums, int left, int right) {
            if (left >= right) return null;
            int mid = (left + right) / 2;
            var root = new TreeNode(nums[mid]) {
                left = create(nums, left, mid),
                right = create(nums, mid + 1, right)
            };
            return root;
        }

        public TreeNode SortedListToBST(ListNode head) {
            IList<int> values = new List<int>();
            while (head != null) {
                values.Add(head.val);
                head = head.next;
            }
            return create(values.ToArray(), 0, values.Count);
        }
    }

    public static void Test() {
        var head = new ListNode("[-10,-3,0,5,9]");
        var s = new Solution();
        var ans = s.SortedListToBST(head);
        Console.WriteLine(ans);
    }
}