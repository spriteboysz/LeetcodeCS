/*
 * Author: Deean
 * Date: 2023-04-08 10:22:41
 * FileName: P0100.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0100 {
    public class Solution {
        public bool IsSameTree(TreeNode p, TreeNode q) {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsSameTree(new TreeNode("[1,2,3]"), new TreeNode("[1,2,3]"));
        Console.WriteLine(ans);
    }
}