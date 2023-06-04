/*
 * Author: Deean
 * Date: 2023-06-04 17:10:22
 * FileName: P1302.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P1302 {
    public class Solution {
        public int DeepestLeavesSum(TreeNode root) {
            int sum = 0;
            if (root == null) return sum;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0) {
                IList<int> level = new List<int>();
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                sum = level.Sum();
            }
            return sum;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3,4,5,null,6,7,null,null,null,null,8]");
        var s = new Solution();
        var ans = s.DeepestLeavesSum(root);
        Console.WriteLine(ans);
    }
}