/*
 * Author: Deean
 * Date: 2023-04-08 09:49:56
 * FileName: P0111.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0111 {
    public class Solution {
        public int MinDepth(TreeNode root) {
            if (root == null) return 0;
            if (root.left == null && root.right == null) {
                return 1;
            }
            if (root.left == null) {
                return MinDepth(root.right) + 1;
            }
            if (root.right == null) {
                return MinDepth(root.left) + 1;
            }
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinDepth(new TreeNode("[3,9,20,null,null,15,7]"));
        Console.WriteLine(ans);
    }
}