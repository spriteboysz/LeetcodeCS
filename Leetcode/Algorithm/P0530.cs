/*
 * Author: Deean
 * Date: 2023-04-05 16:14:39
 * FileName: P0530.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0530 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.left);
            values.Add(root.val);
            DFS(root.right);
        }

        public int GetMinimumDifference(TreeNode root) {
            DFS(root);
            int min = values[1] - values[0];
            for (int i = 2, n = values.Count; i < n; i++) {
                min = Math.Min(min, values[i] - values[i - 1]);
            }
            return min;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetMinimumDifference(new TreeNode("[4,2,6,1,3]"));
        Console.WriteLine(ans);
    }
}