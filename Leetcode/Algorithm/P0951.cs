/*
 * Author: Deean
 * Date: 2023-06-04 23:19:22
 * FileName: P0951.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0951 {
    public class Solution {
        public bool FlipEquiv(TreeNode root1, TreeNode root2) {
            if (root1 == null && root2 == null) return true;
            if (root1 == null || root2 == null) return false;
            if (root1.val != root2.val) return false;
            return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)) ||
                   (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
        }
    }

    public static void Test() {
        var root1 = new TreeNode("[1,2,3,4,5,6,null,null,null,7,8]");
        var root2 = new TreeNode("[1,3,2,null,6,4,5,null,null,null,null,8,7]");
        var s = new Solution();
        var ans = s.FlipEquiv(root1, root2);
        Console.WriteLine(ans);
    }
}