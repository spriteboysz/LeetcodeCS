/*
 * Author: Deean
 * Date: 2023-12-03 17:30:44
 * FileName: LCR0157.cs
 * Description: LCR 157. 套餐内商品的排列顺序
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCP;

public class LCR0157 {
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

        public string[] GoodsOrder(string goods) {
            paths = new List<string>();
            path = new StringBuilder();
            visited = new bool[goods.Length];
            char[] arr = goods.ToCharArray();
            Array.Sort(arr);
            Backtrace(arr, 0);
            return paths.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GoodsOrder("agew");
        Console.WriteLine(ans);
    }
}