/*
 * Author: Deean
 * Date: 2023-04-08 22:04:13
 * FileName: 面试题 17.12. BiNode.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Interview;

public class 面试题_17_12__BiNode {
    public class Solution {
        private IList<TreeNode> nodes = new List<TreeNode>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.left);
            nodes.Add(root);
            DFS(root.right);
        }

        public TreeNode ConvertBiNode(TreeNode root) {
            if (root == null) return null;
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
        var ans = s.ConvertBiNode(new TreeNode("[4,2,5,1,3,null,6,0]"));
        Console.WriteLine(ans);
    }
}