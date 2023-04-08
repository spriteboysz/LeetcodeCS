/*
 * Author: Deean
 * Date: 2023-04-08 10:01:00
 * FileName: P0108.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0108 {
    public class Solution {
        private TreeNode CreateBST(int[] nums, int left, int right) {
            if (left > right) return null;
            int mid = left + (right - left) / 2;
            TreeNode root = new TreeNode(nums[mid]) {
                left = CreateBST(nums, left, mid - 1),
                right = CreateBST(nums, mid + 1, right)
            };
            return root;
        }

        public TreeNode SortedArrayToBST(int[] nums) {
            return CreateBST(nums, 0, nums.Length - 1);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortedArrayToBST(new[] { -10, -3, 0, 5, 9 });
        Console.WriteLine(ans);
    }
}