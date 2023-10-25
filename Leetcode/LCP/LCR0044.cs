/*
 * Author: Deean
 * Date: 2023-10-23 21:27:59
 * FileName: LCR0044.cs
 * Description: LCR 044. 在每个树行中找最大值
 */

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace LCP;

public class LCR0044 {
    public class Solution {
        public IList<int> LargestValues(TreeNode root) {
            IList<int> levels = new List<int>();
            if (root == null) return levels;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                int maximum = queue.First().val;
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    maximum = Math.Max(maximum, node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                levels.Add(maximum);
            }
            return levels;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargestValues(new TreeNode("[1,3,2,5,3,null,9]"));
        Console.WriteLine(Arrays.ToString(ans));
    }
}