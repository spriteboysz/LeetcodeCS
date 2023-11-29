/*
 * Author: Deean
 * Date: 2023-11-26 09:31:11
 * FileName: LCR0145.cs
 * Description: LCR 145. 判断对称二叉树
 */

using System;
using lib;

namespace LCP;

public class LCR0145 {
    public class Solution {
        public bool CheckSymmetricTree(TreeNode root) {
            if (root == null) return true;
            return Check(root.left, root.right);
        }

        private bool Check(TreeNode p, TreeNode q) {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            return p.val == q.val && Check(p.left, q.right) && Check(p.right, q.left);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckSymmetricTree(new TreeNode("[6,7,7,8,9,9,8]"));
        Console.WriteLine(ans);
    }
}