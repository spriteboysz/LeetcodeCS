/*
 * Author: Deean
 * Date: 2023-04-08 16:32:07
 * FileName: 剑指 Offer 55 - I. 二叉树的深度.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_55___I__二叉树的深度 {
    public class Solution {
        public int MaxDepth(TreeNode root) {
            if (root == null) return 0;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxDepth(new TreeNode("[3,9,20,null,null,15,7]"));
        Console.WriteLine(ans);
    }
}