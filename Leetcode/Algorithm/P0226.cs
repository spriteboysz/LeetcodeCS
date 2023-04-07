/*
 * Author: Deean
 * Date: 2023-04-07 22:43:10
 * FileName: P0226.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm; 

public class P0226 {
    public class Solution {
        public TreeNode InvertTree(TreeNode root) {
            if (root == null) return null;
            InvertTree(root.left);
            InvertTree(root.right);
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            return root;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.InvertTree(new TreeNode("[4,2,7,1,3,6,9]"));
        Console.WriteLine(ans);
    }
}