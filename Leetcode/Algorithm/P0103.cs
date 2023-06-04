/*
 * Author: Deean
 * Date: 2023-06-03 22:04:12
 * FileName: P0103.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0103 {
    public class Solution {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
            IList<IList<int>> levels = new List<IList<int>>();
            if (root == null) return levels;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool flag = true;
            while (queue.Count != 0) {
                IList<int> level = new List<int>();
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                if (flag) {
                    levels.Add(level);
                } else {
                    levels.Add(level.ToArray().Reverse().ToList());
                }
                flag = !flag;
            }
            return levels;
        }
    }

    public static void Test() {
        var root = new TreeNode("[3,9,20,null,null,15,7]");
        var s = new Solution();
        var ans = s.ZigzagLevelOrder(root);
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}