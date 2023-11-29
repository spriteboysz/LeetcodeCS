/*
 * Author: Deean
 * Date: 2023-11-28 22:44:55
 * FileName: LCR0150.cs
 * Description: LCR 150. 彩灯装饰记录 II
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0150 {
    public class Solution {
        public IList<IList<int>> DecorateRecord(TreeNode root) {
            IList<IList<int>> levels = new List<IList<int>>();
            if (root == null) return levels;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                IList<int> level = new List<int>();
                for (int i = 0, n = queue.Count; i < n; i++) {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                levels.Add(level);
            }
            return levels;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DecorateRecord(new TreeNode("[8,17,21,18,null,null,6]"));
        Console.WriteLine(ans);
    }
}