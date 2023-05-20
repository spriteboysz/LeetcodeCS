/*
 * Author: Deean
 * Date: 2023-05-20 16:45:55
 * FileName: 剑指 Offer 32 - I. 从上到下打印二叉树.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Sword;

public class 剑指_Offer_32___I__从上到下打印二叉树 {
    public class Solution {
        public int[] LevelOrder(TreeNode root) {
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
        var root = new TreeNode("[3,9,20,null,null,15,7]");
        var s = new Solution();
        var ans = s.LevelOrder(root);
        Console.WriteLine(Arrays.ToString(ans));
    }
}