/*
 * Author: Deean
 * Date: 2023-04-09 11:20:16
 * FileName: 面试题 04.04. 检查平衡性.cs
 * Description:
*/

using System;
using lib;

namespace Interview;

public class 面试题_04_04__检查平衡性 {
    public class Solution {
        private int Height(TreeNode root) {
            if (root == null) return 0;
            return Math.Max(Height(root.left), Height(root.right)) + 1;
        }

        public bool IsBalanced(TreeNode root) {
            if (root == null) return true;
            return Math.Abs(Height(root.left) - Height(root.right)) <= 1 && IsBalanced(root.left) &&
                   IsBalanced(root.right);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsBalanced(new TreeNode("[3,9,20,null,null,15,7]"));
        Console.WriteLine(ans);
    }
}