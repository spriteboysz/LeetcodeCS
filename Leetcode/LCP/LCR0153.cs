/*
 * Author: Deean
 * Date: 2023-12-01 22:03:47
 * FileName: LCR0153.cs
 * Description: LCR 153. 二叉树中和为目标值的路径
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0153 {
    public class Solution {
        private IList<IList<int>> paths;
        private IList<int> path;

        private void Backtrace(TreeNode root, int sum) {
            if (root == null) return;
            path.Add(root.val);
            sum -= root.val;
            if (sum == 0 && root.left == null && root.right == null) {
                paths.Add(new List<int>(path));
            }
            Backtrace(root.left, sum);
            Backtrace(root.right, sum);
            path.RemoveAt(path.Count - 1);
        }

        public IList<IList<int>> PathTarget(TreeNode root, int target) {
            paths = new List<IList<int>>();
            path = new List<int>();
            if (root == null) return paths;
            Backtrace(root, target);
            return paths;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PathTarget(new TreeNode("[5,4,8,11,null,13,4,7,2,null,null,5,1]"), 22);
        Console.WriteLine(ans);
    }
}