/*
 * Author: Deean
 * Date: 2023-04-04 22:47:30
 * FileName: P0501.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0501 {
    public class Solution {
        private Dictionary<int, int> dict = new Dictionary<int, int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.left);
            if (!dict.ContainsKey(root.val)) {
                dict.Add(root.val, 0);
            }
            dict[root.val]++;
            DFS(root.right);
        }

        public int[] FindMode(TreeNode root) {
            DFS(root);
            IList<int> mode = new List<int>();
            int maximum = dict.Values.Max();
            foreach (var key in dict.Keys) {
                if (dict[key] == maximum) {
                    mode.Add(key);
                }
            }
            return mode.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindMode(new TreeNode("[1,null,2,2]"));
        Console.WriteLine(Arrays.ToString(ans));
    }
}