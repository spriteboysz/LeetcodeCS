/*
 * Author: Deean
 * Date: 2023-04-08 10:13:48
 * FileName: P0104.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0104 {
    public class Solution {
        public int MaxDepth(TreeNode root) {
            if (root == null) return 0;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxDepth(new TreeNode("[3,9,20,null,null,15,7]"));
        Console.WriteLine(ans);
    }
}