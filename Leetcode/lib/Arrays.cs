/*
 * Author: Deean
 * Date: 2023-03-18 16:41:43
 * FileName: Array.cs
 * Description:
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace lib {
    public class Arrays {
        public static String ToString<T>(T[] nums) {
            StringBuilder ss = new StringBuilder();
            foreach (var num in nums) {
                ss.Append(num);
                ss.Append(",");
            }
            ss.Remove(ss.Length - 1, 1);
            return "[" + ss + "]";
        }

        public static int[][] To2DArray(string s) {
            s = s.Substring(2, s.Length - 4);
            string[] rows = Regex.Split(s, "],\\[");
            int n = rows.Length;
            int[][] grid = new int[n][];
            for (int k = 0; k < n; k++) {
                string[] words = rows[k].Split(',');
                int m = words.Length;
                int[] row = new int[m];
                for (int i = 0; i < m; i++) {
                    row[i] = Int32.Parse(words[i]);
                }
                grid[k] = row;
            }
            return grid;
        }
    }
}