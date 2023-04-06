/*
 * Author: Deean
 * Date: 2023-04-05 22:14:19
 * FileName: P0404.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0404 {
    public class Solution {
        public int SumOfLeftLeaves(TreeNode root) {
            if (root == null) return 0;
            int sum;
            if (root.left != null && root.left.left == null && root.left.right == null) {
                sum = root.left.val;
            } else {
                sum = SumOfLeftLeaves(root.left);
            }
            sum += SumOfLeftLeaves(root.right);
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumOfLeftLeaves(new TreeNode("[3,9,20,null,null,15,7]"));
        Console.WriteLine(ans);
    }
}