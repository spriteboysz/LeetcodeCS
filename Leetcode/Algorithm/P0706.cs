/*
 * Author: Deean
 * Date: 2023-04-04 15:06:19
 * FileName: P0706.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0706 {
    public class MyHashMap {
        private Dictionary<int, int> dict;

        public MyHashMap() {
            dict = new Dictionary<int, int>();
        }

        public void Put(int key, int value) {
            if (!dict.ContainsKey(key)) {
                dict.Add(key, value);
            } else {
                dict[key] = value;
            }
        }

        public int Get(int key) {
            if (dict.ContainsKey(key)) {
                return dict[key];
            }
            return -1;
        }

        public void Remove(int key) {
            if (dict.ContainsKey(key)) {
                dict.Remove(key);
            }
        }
    }

    public static void Test() {
        MyHashMap obj = new MyHashMap();
        obj.Put(1, 1);
        obj.Put(2, 2);
        Console.WriteLine(obj.Get(1));
        obj.Remove(1);
    }

}