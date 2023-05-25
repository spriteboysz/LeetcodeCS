/*
 * Author: Deean
 * Date: 2023-05-24 22:44:08
 * FileName: 剑指 Offer II 047. 二叉树剪枝.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_II_047__二叉树剪枝 {
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
        var root = new TreeNode("[1,0,1,0,0,0,1]");
        var s = new Solution();
        var ans = s.PruneTree(root);
        Console.WriteLine(ans.ToString());
    }
}