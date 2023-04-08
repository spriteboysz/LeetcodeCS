/*
 * Author: Deean
 * Date: 2023-04-08 09:13:21
 * FileName: P0145.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm; 

public class P0145 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.left);
            DFS(root.right);
            values.Add(root.val);
        }
        public IList<int> PostorderTraversal(TreeNode root) {
            DFS(root);
            return values;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PostorderTraversal(new TreeNode("[1,null,2,3]"));
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}