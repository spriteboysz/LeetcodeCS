/*
 * Author: Deean
 * Date: 2023-04-08 15:43:49
 * FileName: P0102.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0102 {
    public class Solution {
        public IList<IList<int>> LevelOrder(TreeNode root) {
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
        var ans = s.LevelOrder(new TreeNode("[3,9,20,null,null,15,7]"));
        Console.WriteLine(ans);
    }
}