/*
 * Author: Deean
 * Date: 2023-06-04 17:04:40
 * FileName: P0236.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0236 {
    public class Solution {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            if (root == null || root.val == p.val || root.val == q.val) {
                return root;
            }
            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);
            if (left == null) return right;
            if (right == null) return left;
            return root;
        }
    }

    public static void Test() {
        var root = new TreeNode("[3,5,1,6,2,0,8,null,null,7,4]");
        var p = new TreeNode(5);
        var q = new TreeNode(1);
        var s = new Solution();
        var ans = s.LowestCommonAncestor(root, p, q);
        Console.WriteLine(ans);
    }
}