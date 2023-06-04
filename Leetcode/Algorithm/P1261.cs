/*
 * Author: Deean
 * Date: 2023-06-04 20:59:19
 * FileName: P1261.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P1261 {
    public class FindElements {
        private HashSet<int> values;

        private void dfs(TreeNode root) {
            int value = root.val;
            values.Add(value);
            TreeNode left = root.left, right = root.right;
            if (left != null) {
                left.val = 2 * value + 1;
                dfs(left);
            }
            if (right != null) {
                right.val = 2 * value + 2;
                dfs(right);
            }
        }

        public FindElements(TreeNode root) {
            values = new HashSet<int>();
            root.val = 0;
            dfs(root);
        }

        public bool Find(int target) {
            return values.Contains(target);
        }
    }

    public static void Test() {
        var root = new TreeNode("[-1,-1,-1,-1,-1]");
        FindElements obj = new FindElements(root);
        Console.WriteLine(obj.Find(1));
        Console.WriteLine(obj.Find(3));
        Console.WriteLine(obj.Find(5));
    }
}