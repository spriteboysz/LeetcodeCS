/*
 * Author: Deean
 * Date: 2023-04-05 16:28:45
 * FileName: P0543.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0543 {
    public class Solution {
        private int maximum;

        private int Depth(TreeNode root) {
            if (root == null) return 0;
            int left = Depth(root.left);
            int right = Depth(root.right);
            maximum = Math.Max(maximum, left + right + 1);
            return Math.Max(left, right) + 1;
        }

        public int DiameterOfBinaryTree(TreeNode root) {
            maximum = 1;
            Depth(root);
            return maximum - 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DiameterOfBinaryTree(new TreeNode("[1,2,3,4,5]"));
        Console.WriteLine(ans);
    }
}