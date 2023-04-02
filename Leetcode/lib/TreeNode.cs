/*
 * Author: Deean
 * Date: 2023-03-18 14:44:38
 * FileName: TreeNode.cs
 * Description:
*/

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lib;

// Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public TreeNode(string data) {
        if (data is null or "") {
            return;
        }
        string[] values = data.Substring(1, data.Length - 2).Split(',').ToArray();
        TreeNode root = new TreeNode(int.Parse(values[0]));
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        while (queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            if (i < values.Length && !Equals("null", values[i])) {
                node.left = new TreeNode(int.Parse(values[i]));
                queue.Enqueue(node.left);
            }
            i++;
            if (i < values.Length && !Equals("null", values[i])) {
                node.right = new TreeNode(int.Parse(values[i]));
                queue.Enqueue(node.right);
            }
            i++;
        }
        val = root.val;
        left = root.left;
        right = root.right;
    }

    public override string ToString() {
        StringBuilder ss = new StringBuilder();
        ss.Append("[");
        Queue<TreeNode> queue = new Queue<TreeNode>();
        while (queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            if (node != null && !Equals(node.val.ToString(), "null")) {
                ss.Append(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            } else {
                ss.Append("null");
            }
            ss.Append(",");
        }
        ss.Append("]");
        string str = ss.ToString();
        while (str.Contains("null,]")) {
            str = str.Replace("null,]", "]");
        }
        return str.Replace(",]", "]");
    }
}