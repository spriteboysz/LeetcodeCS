/*
 * Author: Deean
 * Date: 2023-06-06 23:28:10
 * FileName: P2545.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P2545 {
    public class Solution {
        public int[][] SortTheStudents(int[][] score, int k) {
            Array.Sort(score, (nums1, nums2) => nums1[k] - nums2[k]);
            return score;
        }
    }

    public static void Test() {
        var score = Arrays.To2DArray("[[10,6,9,1],[7,5,11,2],[4,8,3,15]]");
        var s = new Solution();
        var ans = s.SortTheStudents(score, 2);
        Console.WriteLine(ans);
    }
}