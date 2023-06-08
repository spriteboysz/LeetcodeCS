/*
 * Author: Deean
 * Date: 2023-06-07 23:04:47
 * FileName: P2331.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P2331 {
    public class Solution {
        public bool EvaluateTree(TreeNode root) {
            if (root.left == null) return root.val == 1;
            if (root.val == 2) {
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            }
            return EvaluateTree(root.left) && EvaluateTree(root.right);
        }
    }

    public static void Test() {
        var root = new TreeNode("[2,1,3,null,null,0,1]");
        var s = new Solution();
        var ans = s.EvaluateTree(root);
        Console.WriteLine(ans);
    }
}