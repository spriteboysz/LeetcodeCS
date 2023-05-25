/*
 * Author: Deean
 * Date: 2023-05-24 22:11:24
 * FileName: 剑指 Offer II 044. 二叉树每层的最大值.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_044__二叉树每层的最大值 {
    public class Solution {
        public IList<int> LargestValues(TreeNode root) {
            IList<int> levels = new List<int>();
            if (root == null) return levels;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                int level = Int32.MinValue;
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    level = Math.Max(level, node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                levels.Add(level);
            }
            return levels;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,3,2,5,3,null,9]");
        var s = new Solution();
        var ans = s.LargestValues(root);
        Console.WriteLine(Arrays.ToString(ans));
    }
}