/*
 * Author: Deean
 * Date: 2023-04-04 13:41:32
 * FileName: P0671.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm; 

public class P0671 {
    public class Solution {
        private HashSet<int> values = new HashSet<int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.left);
            values.Add(root.val);
            DFS(root.right);
        }
        public int FindSecondMinimumValue(TreeNode root) {
            DFS(root);
            List<int> list = values.ToList();
            list.Sort();
            return list.Count < 2 ? -1 : list[1];
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindSecondMinimumValue(new TreeNode("[2,2,5,null,null,5,7]"));
        Console.WriteLine(ans);
    }
}