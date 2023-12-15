/*
 * Author: Deean
 * Date: 2023-12-15 21:55:36
 * FileName: LCR0176.cs
 * Description: LCR 176. 判断是否为平衡二叉树
 */

using System;
using lib;

namespace LCP;

public class LCR0176 {
    public class Solution {
        private int Height(TreeNode root) {
            if (root == null) return 0;
            return Math.Max(Height(root.left), Height(root.right)) + 1;
        }

        public bool IsBalanced(TreeNode root) {
            if (root == null) return true;
            return Math.Abs(Height(root.left) - Height(root.right)) <= 1 && IsBalanced(root.left) &&
                   IsBalanced(root.right);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsBalanced(new TreeNode("[3,9,20,null,null,15,7]"));
        Console.WriteLine(ans);
    }
}