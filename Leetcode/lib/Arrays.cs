/*
 * Author: Deean
 * Date: 2023-03-18 16:41:43
 * FileName: Array.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lib {
    public class Arrays {
        public static string ToString<T>(IEnumerable<T> nums) {
            StringBuilder ss = new StringBuilder();
            ss.Append("[");
            foreach (var num in nums) {
                ss.Append(num);
                ss.Append(",");
            }
            ss.Append("]");
            ss.Replace(",]", "]");
            return ss.ToString();
        }

        public static string ToString<T>(IEnumerable<T[]> grid) {
            StringBuilder ss = new StringBuilder();
            ss.Append("[");
            foreach (var row in grid) {
                ss.Append("[");
                foreach (var num in row) {
                    ss.Append(num);
                    ss.Append(",");
                }
                ss.Append("]");
                ss.Append(",");
            }
            ss.Append("]");
            ss.Replace(",]", "]");
            return ss.ToString();
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