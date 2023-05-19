/*
 * Author: Deean
 * Date: 2023-05-19 22:04:15
 * FileName: P2583.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P2583 {
    public class Solution {
        public long KthLargestLevelSum(TreeNode root, int k) {
            if (root == null) return -1;
            IList<long> levels = new List<long>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0) {
                long level = 0L;
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    level += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                levels.Add(level);
            }
            if (levels.Count < k) {
                return -1;
            }
            ((List<long>)levels).Sort();
            return levels[levels.Count - k];
        }
    }

    public static void Test() {
        var root = new TreeNode("[5,8,9,2,1,3,7,4,6]");
        var s = new Solution();
        var ans = s.KthLargestLevelSum(root, 2);
        Console.WriteLine(ans);
    }
}