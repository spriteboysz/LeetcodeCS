/*
 * Author: Deean
 * Date: 2023-03-19 13:25:05
 * FileName: P2236.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm; 

public class P2236 {
    public class Solution {
        public bool CheckTree(TreeNode root) {
            return root.left.val + root.right.val == root.val;
        } 
    }

    public static void Test() {
        TreeNode root = new TreeNode();
        var s = new Solution();
        var ans = s.CheckTree(root);
        Console.WriteLine(ans);
    }
}