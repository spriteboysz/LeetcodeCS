/*
 * Author: Deean
 * Date: 2023-04-08 10:16:21
 * FileName: P0101.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0101 {
    public class Solution {
        private bool Check(TreeNode root1, TreeNode root2) {
            if (root1 == null && root2 == null) {
                return true;
            }
            if (root1 == null || root2 == null) {
                return false;
            }
            return root1.val == root2.val && Check(root1.left, root2.right) && Check(root1.right, root2.left);
        }

        public bool IsSymmetric(TreeNode root) {
            return Check(root.left, root.right);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsSymmetric(new TreeNode("[1,2,2,3,4,4,3]"));
        Console.WriteLine(ans);
    }
}