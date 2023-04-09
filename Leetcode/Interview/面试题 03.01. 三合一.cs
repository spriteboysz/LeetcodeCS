/*
 * Author: Deean
 * Date: 2023-04-09 10:58:13
 * FileName: 面试题 03.01. 三合一.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_03_01__三合一 {
    public class TripleInOne {
        private int stackSize;
        private int[] stack;
        private int[] index;

        public TripleInOne(int stackSize) {
            this.stackSize = stackSize;
            stack = new int[stackSize * 3];
            index = new[] { -1, -1, -1 };
        }

        public void Push(int stackNum, int value) {
            if (index[stackNum] + 1 < stackSize) {
                index[stackNum]++;
                stack[stackNum * stackSize + index[stackNum]] = value;
            }
        }

        public int Pop(int stackNum) {
            if (IsEmpty(stackNum)) return -1;
            int value = stack[stackNum * stackSize + index[stackNum]];
            stack[stackNum * stackSize + index[stackNum]] = 0;
            index[stackNum]--;
            return value;
        }

        public int Peek(int stackNum) {
            if (IsEmpty(stackNum)) return -1;
            return stack[stackNum * stackSize + index[stackNum]];
        }

        public bool IsEmpty(int stackNum) {
            return index[stackNum] < 0;
        }
    }

    public static void Test() {
        TripleInOne obj = new TripleInOne(2);
        obj.Push(0, 1);
        obj.Push(0, 2);
        obj.Push(0, 3);
        Console.WriteLine(obj.Pop(0));
        Console.WriteLine(obj.Pop(0));
        Console.WriteLine(obj.Pop(0));
        Console.WriteLine(obj.Peek(0));
    }
}