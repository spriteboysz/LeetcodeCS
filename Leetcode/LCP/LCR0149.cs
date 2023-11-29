/*
 * Author: Deean
 * Date: 2023-11-27 22:52:52
 * FileName: LCR0149.cs
 * Description: LCR 149. 彩灯装饰记录 I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace LCP;

public class LCR0149 {
    public class Solution {
        public int[] DecorateRecord(TreeNode root) {
            IList<int> levels = new List<int>();
            if (root == null) return levels.ToArray();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0) {
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    levels.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }
            return levels.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DecorateRecord(new TreeNode("[8,17,21,18,null,null,6]"));
        Console.WriteLine(ans);
    }
}