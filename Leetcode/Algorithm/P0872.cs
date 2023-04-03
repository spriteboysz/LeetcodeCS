/*
 * Author: Deean
 * Date: 2023-04-02 21:49:59
 * FileName: P0872.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0872 {
    public class Solution {
        public void dfs(TreeNode root, IList<int> leaf) {
            if (root == null) return;
            if (root.left == null && root.right == null) {
                leaf.Add(root.val);
            }
            dfs(root.left, leaf);
            dfs(root.right, leaf);
        }

        public bool LeafSimilar(TreeNode root1, TreeNode root2) {
            IList<int> leaf1 = new List<int>();
            IList<int> leaf2 = new List<int>();
            dfs(root1, leaf1);
            dfs(root2, leaf2);
            return leaf1.SequenceEqual(leaf2);
        }
    }

    public static void Test() {
        TreeNode root1 = new TreeNode("[3,5,1,6,2,9,8,null,null,7,4]");
        TreeNode root2 = new TreeNode("[3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]");
        var s = new Solution();
        var ans = s.LeafSimilar(root1, root2);
        Console.WriteLine(ans);
    }
}