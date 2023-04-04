/*
 * Author: Deean
 * Date: 2023-04-04 11:03:19
 * FileName: P0783.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0783 {
    public class Solution {
        private readonly IList<int> values = new List<int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.left);
            values.Add(root.val);
            DFS(root.right);
        }

        public int MinDiffInBST(TreeNode root) {
            DFS(root);
            int minimum = Int32.MaxValue;
            for (int i = 1; i < values.Count; i++) {
                minimum = Math.Min(minimum, values[i] - values[i - 1]);
            }
            return minimum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinDiffInBST(new TreeNode("[4,2,6,1,3]"));
        Console.WriteLine(ans);
    }
}