/*
 * Author: Deean
 * Date: 2023-04-08 15:58:07
 * FileName: 剑指 Offer 40. 最小的k个数.cs
 * Description:
*/

using System;

namespace Sword; 

public class 剑指_Offer_40__最小的k个数 {
    public class Solution {
        public int[] GetLeastNumbers(int[] arr, int k) {
            Array.Sort(arr);
            int[] least = new int[k];
            for (int i = 0; i < k; i++) {
                least[i] = arr[i];
            }
            return least;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetLeastNumbers(new []{3,2,1}, 2);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}