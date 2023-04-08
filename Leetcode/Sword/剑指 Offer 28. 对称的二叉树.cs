/*
 * Author: Deean
 * Date: 2023-04-08 14:29:58
 * FileName: 剑指 Offer 28. 对称的二叉树.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_28__对称的二叉树 {
    public class Solution {
        private bool Check(TreeNode p, TreeNode q) {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            return p.val == q.val && Check(p.left, q.right) && Check(p.right, q.left);
        }

        public bool IsSymmetric(TreeNode root) {
            if (root == null) return true;
            return Check(root.left, root.right);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsSymmetric(new TreeNode("[1,2,2,3,4,4,3]"));
        Console.WriteLine(ans);
    }
}