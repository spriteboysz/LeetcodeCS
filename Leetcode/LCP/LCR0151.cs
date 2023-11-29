/*
 * Author: Deean
 * Date: 2023-11-29 21:57:35
 * FileName: LCR0151.cs
 * Description: LCR 151. 彩灯装饰记录 III
 */

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace LCP;

public class LCR0151 {
    public class Solution {
        public IList<IList<int>> DecorateRecord(TreeNode root) {
            IList<IList<int>> levels = new List<IList<int>>();
            if (root == null) return levels;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int k = 0;
            while (queue.Count != 0) {
                IList<int> level = new List<int>();
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                if (k % 2 == 1) {
                    level = level.Reverse().ToList();
                }
                levels.Add(level);
                k += 1;
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