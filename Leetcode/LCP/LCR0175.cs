/*
 * Author: Deean
 * Date: 2023-12-14 22:42:01
 * FileName: LCR0175.cs
 * Description: LCR 175. 计算二叉树的深度
 */

using System;
using lib;

namespace LCP;

public class LCR0175 {
    public class Solution {
        public int CalculateDepth(TreeNode root) {
            if (root == null) return 0;
            return Math.Max(CalculateDepth(root.left), CalculateDepth(root.right)) + 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CalculateDepth(new TreeNode("[1,2,2,3,null,null,5,4,null,null,4]"));
        Console.WriteLine(ans);
    }
}