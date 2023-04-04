/*
 * Author: Deean
 * Date: 2023-04-04 15:13:17
 * FileName: P0705.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0705 {
    public class MyHashSet {
        private HashSet<int> set;

        public MyHashSet() {
            set = new HashSet<int>();
        }

        public void Add(int key) {
            set.Add(key);
        }

        public void Remove(int key) {
            if (set.Contains(key)) {
                set.Remove(key);
            }
        }

        public bool Contains(int key) {
            return set.Contains(key);
        }
    }

    public static void Test() {
        MyHashSet obj = new MyHashSet();
        obj.Add(1);
        obj.Remove(1);
        Console.WriteLine(obj.Contains(1));
    }
}