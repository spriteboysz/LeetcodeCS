/*
 * Author: Deean
 * Date: 2023-05-20 21:19:50
 * FileName: P0113.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm; 

public class P0113 {
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
        
        public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
            paths = new List<IList<int>>();
            path = new List<int>();
            if (root == null) return paths;
            Backtrace(root, targetSum);
            return paths;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var root = new TreeNode("[5,4,8,11,null,13,4,7,2,null,null,5,1]");
        var ans = s.PathSum(root, 22);
        Console.WriteLine(Arrays.ToString(ans));
    }
}