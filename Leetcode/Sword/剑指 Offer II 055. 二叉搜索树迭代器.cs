/*
 * Author: Deean
 * Date: 2023-05-26 22:11:50
 * FileName: 剑指 Offer II 055. 二叉搜索树迭代器.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_055__二叉搜索树迭代器 {
    public class BSTIterator {
        private IList<int> values;
        private int i;

        private void dfs(TreeNode? root) {
            if (root == null) return;
            dfs(root.left);
            values.Add(root.val);
            dfs(root.right);
        }

        public BSTIterator(TreeNode? root) {
            values = new List<int>();
            dfs(root);
        }

        public int Next() {
            return values[i++];
        }

        public bool HasNext() {
            return values.Count > i;
        }
    }

    public static void Test() {
        var root = new TreeNode("[7,3,15,null,null,9,20]");
        BSTIterator obj = new BSTIterator(root);
        Console.WriteLine(obj.Next());
        Console.WriteLine(obj.HasNext());
    }
}