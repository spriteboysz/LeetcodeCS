/*
 * Author: Deean
 * Date: 2023-03-18 11:36:46
 * FileName: P2540.cs
 * Description:
*/

namespace Algorithm;

public class P2540 {
    public class Solution {
        public int GetCommon(int[] nums1, int[] nums2) {
            for (int i = 0, j = 0; i < nums1.Length && j < nums2.Length;) {
                if (nums1[i] > nums2[j]) {
                    j++;
                }
                else if (nums1[i] < nums2[j]) {
                    i++;
                }
                else {
                    return nums1[i];
                }
            }

            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetCommon(new[] { 1, 2, 3 }, new[] { 2, 3, 4 });
        System.Console.WriteLine(ans);
    }
}