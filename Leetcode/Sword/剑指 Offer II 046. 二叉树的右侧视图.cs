/*
 * Author: Deean
 * Date: 2023-05-24 22:34:11
 * FileName: 剑指 Offer II 046. 二叉树的右侧视图.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_046__二叉树的右侧视图 {
    public class Solution {
        public IList<int> RightSideView(TreeNode root) {
            IList<int> levels = new List<int>();
            if (root == null) return levels;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                int level = 0;
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    level = node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                levels.Add(level);
            }
            return levels;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3,null,5,null,4]");
        var s = new Solution();
        var ans = s.RightSideView(root);
        Console.WriteLine(Arrays.ToString(ans));
    }
}