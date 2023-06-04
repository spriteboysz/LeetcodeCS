/*
 * Author: Deean
 * Date: 2023-06-03 22:14:37
 * FileName: P0107.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0107 {
    public class Solution {
        public IList<IList<int>> LevelOrderBottom(TreeNode root) {
            IList<IList<int>> levels = new List<IList<int>>();
            if (root == null) return levels;
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
                levels.Insert(0, level);
            }
            return levels;
        }
    }

    public static void Test() {
        var root = new TreeNode("[3,9,20,null,null,15,7]");
        var s = new Solution();
        var ans = s.LevelOrderBottom(root);
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}