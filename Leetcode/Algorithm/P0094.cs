/*
 * Author: Deean
 * Date: 2023-04-08 10:25:38
 * FileName: P0094.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0094 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.left);
            values.Add(root.val);
            DFS(root.right);
        }

        public IList<int> InorderTraversal(TreeNode root) {
            DFS(root);
            return values;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.InorderTraversal(new TreeNode("[1,null,2,3]"));
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}