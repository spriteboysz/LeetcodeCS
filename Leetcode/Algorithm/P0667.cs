/*
 * Author: Deean
 * Date: 2023-05-27 22:50:44
 * FileName: P0667.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0667 {
    public class MapSum {
        private IDictionary<string, int> dict;

        public MapSum() {
            dict = new Dictionary<string, int>();
        }

        public void Insert(string key, int val) {
            dict[key] = val;
        }

        public int Sum(string prefix) {
            int cnt = 0;
            foreach (var word in dict.Keys) {
                if (word.StartsWith(prefix)) {
                    cnt += dict[word];
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        MapSum obj = new MapSum();
        obj.Insert("apple", 3);
        Console.WriteLine(obj.Sum("ap"));
        obj.Insert("app", 2);
        Console.WriteLine(obj.Sum("ap"));
    }
}