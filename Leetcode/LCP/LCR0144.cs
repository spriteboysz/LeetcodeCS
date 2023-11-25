/*
 * Author: Deean
 * Date: 2023-11-25 21:58:59
 * FileName: LCR0144.cs
 * Description: LCR 144. 翻转二叉树
*/

using System;
using lib;

namespace LCP; 

public class LCR0144 {
    public class Solution {
        public TreeNode MirrorTree(TreeNode root) {
            if (root == null) return null;
            TreeNode left = MirrorTree(root.left);
            TreeNode right = MirrorTree(root.right);
            root.left = right;
            root.right = left;
            return root;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MirrorTree(new TreeNode("[5,7,9,8,3,2,4]"));
        Console.WriteLine(ans);
    }
}