/*
 * Author: Deean
 * Date: 2023-06-04 23:08:16
 * FileName: P0701.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0701 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            values.Add(root.val);
            dfs(root.right);
        }

        private TreeNode create(int[] vals, int left, int right) {
            if (left >= right) return null;
            int mid = (left + right) / 2;
            var root = new TreeNode(vals[mid]) {
                left = create(vals, left, mid),
                right = create(vals, mid + 1, right)
            };
            return root;
        }

        public TreeNode InsertIntoBST(TreeNode root, int val) {
            dfs(root);
            values.Add(val);
            int[] vals = values.ToArray();
            Array.Sort(vals);
            return create(vals, 0, vals.Length);
        }
    }

    public static void Test() {
        var root = new TreeNode("[4,2,7,1,3]");
        var s = new Solution();
        var ans = s.InsertIntoBST(root, 5);
        Console.WriteLine(ans);
    }
}