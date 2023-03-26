/*
 * Author: Deean
 * Date: 2023-03-26 22:51:55
 * FileName: P1436.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1436 {
    public class Solution {
        public string DestCity(IList<IList<string>> paths) {
            HashSet<string> src = new HashSet<string>();
            HashSet<string> dst = new HashSet<string>();
            foreach (var path in paths) {
                src.Add(path[0]);
                dst.Add(path[1]);
            }
            foreach (var city in dst) {
                if (!src.Contains(city)) {
                    return city;
                }
            }
            return "";
        }
    }

    public static void Test() {
        IList<IList<string>> paths = new List<IList<string>>();
        IList<string> path0 = new List<string> { "London", "New York" };
        IList<string> path1 = new List<string> { "New York", "Lima" };
        IList<string> path2 = new List<string> { "Lima", "Sao Paulo" };
        paths.Add(path0);
        paths.Add(path1);
        paths.Add(path2);
        var s = new Solution();
        var ans = s.DestCity(paths);
        Console.WriteLine(ans);
    }
}