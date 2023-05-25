/*
 * Author: Deean
 * Date: 2023-05-24 22:51:14
 * FileName: P0814.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0814 {
    public class Solution {
        public TreeNode PruneTree(TreeNode root) {
            if (root == null) return null;
            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);
            if (root.val == 0 && root.left == null && root.right == null) {
                return null;
            }
            return root;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,null,0,0,1]");
        var s = new Solution();
        var ans = s.PruneTree(root);
        Console.WriteLine(ans);
    }
}