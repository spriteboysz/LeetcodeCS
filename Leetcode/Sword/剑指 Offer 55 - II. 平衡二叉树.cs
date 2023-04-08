/*
 * Author: Deean
 * Date: 2023-04-08 16:34:56
 * FileName: 剑指 Offer 55 - II. 平衡二叉树.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_55___II__平衡二叉树 {
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