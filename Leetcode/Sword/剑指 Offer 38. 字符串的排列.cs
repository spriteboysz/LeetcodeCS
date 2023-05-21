/*
 * Author: Deean
 * Date: 2023-05-20 22:04:39
 * FileName: 剑指 Offer 38. 字符串的排列.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib;

namespace Sword;

public class 剑指_Offer_38__字符串的排列 {
    public class Solution {
        private IList<string> paths;
        private StringBuilder path;
        private bool[] visited;

        private void Backtrace(char[] arr, int pos) {
            if (pos == arr.Length) {
                paths.Add(path.ToString());
            }
            for (int i = 0; i < arr.Length; i++) {
                if (visited[i] || (i > 0 && arr[i - 1] == arr[i] && !visited[i - 1])) {
                    continue;
                }
                visited[i] = true;
                path.Append(arr[i]);
                Backtrace(arr, pos + 1);
                path.Length--;
                visited[i] = false;
            }
        }

        public string[] Permutation(string s) {
            paths = new List<string>();
            path = new StringBuilder();
            visited = new bool[s.Length];
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            Backtrace(arr, 0);
            return paths.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Permutation("abc");
        Console.WriteLine(Arrays.ToString(ans));
    }
}