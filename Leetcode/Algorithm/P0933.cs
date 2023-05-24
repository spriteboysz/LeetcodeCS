/*
 * Author: Deean
 * Date: 2023-05-24 22:05:34
 * FileName: P0933.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0933 {
    public class RecentCounter {
        private Queue<int> queue;

        public RecentCounter() {
            queue = new Queue<int>();
        }

        public int Ping(int t) {
            queue.Enqueue(t);
            while (queue.Peek() < t - 3000) {
                queue.Dequeue();
            }
            return queue.Count;
        }
    }

    public static void Test() {
        var obj = new RecentCounter();
        Console.WriteLine(obj.Ping(1));
        Console.WriteLine(obj.Ping(100));
        Console.WriteLine(obj.Ping(3001));
        Console.WriteLine(obj.Ping(3002));
    }
}