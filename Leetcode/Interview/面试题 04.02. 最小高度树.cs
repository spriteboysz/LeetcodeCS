/*
 * Author: Deean
 * Date: 2023-04-09 11:14:13
 * FileName: 面试题 04.02. 最小高度树.cs
 * Description:
*/

using System;
using lib;

namespace Interview;

public class 面试题_04_02__最小高度树 {
    public class Solution {
        public TreeNode SortedArrayToBST(int[] nums) {
            return CreateBST(nums, 0, nums.Length - 1);
        }

        private TreeNode CreateBST(int[] nums, int left, int right) {
            if (left > right) return null;
            int mid = left + (right - left) / 2;
            TreeNode root = new TreeNode(nums[mid]) {
                left = CreateBST(nums, left, mid - 1),
                right = CreateBST(nums, mid + 1, right)
            };
            return root;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortedArrayToBST(new[] { -10, -3, 0, 5, 9 });
        Console.WriteLine(ans);
    }
}