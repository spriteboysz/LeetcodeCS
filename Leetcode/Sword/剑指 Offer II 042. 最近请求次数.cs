/*
 * Author: Deean
 * Date: 2023-05-24 22:01:12
 * FileName: 剑指 Offer II 042. 最近请求次数.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_042__最近请求次数 {
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