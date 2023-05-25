/*
 * Author: Deean
 * Date: 2023-05-24 23:17:38
 * FileName: P0297.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;
using lib;

namespace Algorithm;

public class P0297 {
    public class Codec {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root) {
            if (root == null) return "#";
            StringBuilder ss = new StringBuilder();
            ss.Append(root.val);
            ss.Append(',');
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                var node = queue.Dequeue();
                TreeNode left = node.left, right = node.right;
                if (left == null) {
                    ss.Append("#");
                } else {
                    ss.Append(left.val);
                    queue.Enqueue(left);
                }
                ss.Append(",");
                if (right == null) {
                    ss.Append("#");
                } else {
                    ss.Append(right.val);
                    queue.Enqueue(right);
                }
                ss.Append(",");
            }
            ss.Length--;
            return ss.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data) {
            if ("#".Equals(data)) return null;
            string[] ss = data.Split(',');
            TreeNode root = new TreeNode(int.Parse(ss[0]));
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool isLeftNull = false;
            for (int i = 1, n = ss.Length; i < n; i++) {
                String str = ss[i];
                TreeNode parent = queue.Peek();
                TreeNode node = "#".Equals(str) ? null : new TreeNode(int.Parse(str));
                if (parent.left == null && !isLeftNull) {
                    parent.left = node;
                    if (node == null) {
                        isLeftNull = true;
                    }
                } else {
                    parent.right = node;
                    queue.Dequeue();
                    isLeftNull = false;
                }
                if (node != null) {
                    queue.Enqueue(node);
                }
            }
            return root;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3,null,null,4,5]");
        Codec ser = new Codec();
        Codec deser = new Codec();
        TreeNode ans = deser.deserialize(ser.serialize(root));
        Console.WriteLine(ans);
    }
}