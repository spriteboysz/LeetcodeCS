/*
 * Author: Deean
 * Date: 2023-04-08 18:04:23
 * FileName: 剑指 Offer II 041. 滑动窗口的平均值.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword; 

public class 剑指_Offer_II_041__滑动窗口的平均值 {
    public class MovingAverage {
        Queue<int> queue;
        int size;
        double sum;
        public MovingAverage(int size) {
            queue = new Queue<int>();
            this.size = size;
            sum = 0;
        }
    
        public double Next(int val) {
            if (queue.Count == size) {
                sum -= queue.Dequeue();
            }
            queue.Enqueue(val);
            sum += val;
            return sum / queue.Count;
        }
    }

    public static void Test() {
        MovingAverage obj = new MovingAverage(3);
        Console.WriteLine(obj.Next(1));
        Console.WriteLine(obj.Next(10));
        Console.WriteLine(obj.Next(3));
        Console.WriteLine(obj.Next(5));
    }
}