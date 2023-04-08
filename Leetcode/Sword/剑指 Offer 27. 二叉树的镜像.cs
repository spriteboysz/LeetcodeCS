/*
 * Author: Deean
 * Date: 2023-04-08 14:25:16
 * FileName: 剑指 Offer 27. 二叉树的镜像.cs
 * Description:
*/

using System;
using lib;

namespace Sword; 

public class 剑指_Offer_27__二叉树的镜像 {
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
        var ans = s.MirrorTree(new TreeNode("[4,2,7,1,3,6,9]"));
        Console.WriteLine(ans);
    }
}