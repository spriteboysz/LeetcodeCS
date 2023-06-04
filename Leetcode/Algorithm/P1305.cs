/*
 * Author: Deean
 * Date: 2023-06-04 20:41:19
 * FileName: P1305.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P1305 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            values.Add(root.val);
            dfs(root.right);
        }

        public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
            dfs(root1);
            dfs(root2);
            int[] val = values.ToArray();
            Array.Sort(val);
            return val.ToList();
        }
    }

    public static void Test() {
        var root1 = new TreeNode("[2,1,4]");
        var root2 = new TreeNode("[1,0,3]");
        var s = new Solution();
        var ans = s.GetAllElements(root1, root2);
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}