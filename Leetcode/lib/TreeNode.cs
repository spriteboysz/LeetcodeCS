/*
 * Author: Deean
 * Date: 2023-03-18 14:44:38
 * FileName: TreeNode.cs
 * Description:
*/

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
}