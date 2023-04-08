/*
 * Author: Deean
 * Date: 2023-04-08 09:19:25
 * FileName: P0144.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0144 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            values.Add(root.val);
            DFS(root.left);
            DFS(root.right);
        }

        public IList<int> PreorderTraversal(TreeNode root) {
            DFS(root);
            return values;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PreorderTraversal(new TreeNode("[1,null,2,3]"));
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}