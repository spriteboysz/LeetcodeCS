/*
 * Author: Deean
 * Date: 2023-04-08 19:07:18
 * FileName: 剑指 Offer II 052. 展平二叉搜索树.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_052__展平二叉搜索树 {
    public class Solution {
        private IList<TreeNode> nodes = new List<TreeNode>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.left);
            nodes.Add(root);
            DFS(root.right);
        }

        public TreeNode IncreasingBST(TreeNode root) {
            DFS(root);
            for (int i = 0, n = nodes.Count; i < n - 1; i++) {
                nodes[i].left = null;
                nodes[i].right = nodes[i + 1];
            }
            nodes[nodes.Count - 1].left = null;
            nodes[nodes.Count - 1].right = null;
            return nodes[0];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IncreasingBST(new TreeNode("[5,3,6,2,4,null,8,1,null,null,null,7,9]"));
        Console.WriteLine(ans);
    }
}