/*
 * Author: Deean
 * Date: 2023-05-25 23:45:25
 * FileName: 剑指 Offer II 053. 二叉搜索树中的中序后继.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_053__二叉搜索树中的中序后继 {
    public class Solution {
        private IList<TreeNode> nodes = new List<TreeNode>();

        void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            nodes.Add(root);
            dfs(root.right);
        }

        public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
            dfs(root);
            for (int i = 0, n = nodes.Count; i < n - 1; i++) {
                if (nodes[i].val == p.val) {
                    return nodes[i + 1];
                }
            }
            return null;
        }
    }

    public static void Test() {
        var root = new TreeNode("[2,1,3]");
        var p = new TreeNode(1);
        var s = new Solution();
        var ans = s.InorderSuccessor(root, p);
        Console.WriteLine(ans);
    }
}