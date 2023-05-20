/*
 * Author: Deean
 * Date: 2023-05-20 19:55:50
 * FileName: 剑指 Offer 32 - III. 从上到下打印二叉树 III.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Sword;

public class 剑指_Offer_32___III__从上到下打印二叉树_III {
    public class Solution {
        public IList<IList<int>> LevelOrder(TreeNode root) {
            IList<IList<int>> levels = new List<IList<int>>();
            if (root == null) return levels;
            var queue = new Queue<TreeNode>();
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
        var root = new TreeNode("[3,9,20,null,null,15,7]");
        var ans = s.LevelOrder(root);
        Console.WriteLine(Arrays.ToString(ans));
    }
}