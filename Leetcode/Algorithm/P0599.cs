/*
 * Author: Deean
 * Date: 2023-04-05 17:50:26
 * FileName: P0599.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0599 {
    public class Solution {
        public string[] FindRestaurant(string[] list1, string[] list2) {
            Dictionary<string, int> common = new Dictionary<string, int>();
            foreach (var name in list1.Concat(list2)) {
                if (!common.ContainsKey(name)) {
                    common.Add(name, 0);
                }
                common[name]++;
            }
            Dictionary<string, int> favourite = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++) {
                if (common.ContainsKey(list1[i]) && common[list1[i]] == 2) {
                    favourite.Add(list1[i], i);
                }
            }
            for (int i = 0; i < list2.Length; i++) {
                if (common.ContainsKey(list2[i]) && common[list2[i]] == 2) {
                    favourite[list2[i]] += i;
                }
            }

            int minimum = favourite.Values.Min();
            return favourite.Keys.Where(k => favourite[k] == minimum).ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindRestaurant(new[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new[] { "KFC", "Shogun", "Burger King" });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}