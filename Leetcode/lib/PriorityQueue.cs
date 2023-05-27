/*
 * Author: Deean
 * Date: 2023-05-26 23:20:54
 * FileName: PriorityQueue.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace lib;

public class PriorityQueue<T> where T : IComparable<T> {
    private SortedList<T, int> list = new SortedList<T, int>();
    private int count;

    public void Add(T item) {
        if (list.ContainsKey(item)) list[item]++;
        else list.Add(item, 1);

        count++;
    }

    public T PopFirst() {
        if (Size() == 0) return default(T);
        T result = list.Keys[0];
        if (--list[result] == 0)
            list.RemoveAt(0);

        count--;
        return result;
    }

    public T PopLast() {
        if (Size() == 0) return default(T);
        int index = list.Count - 1;
        T result = list.Keys[index];
        if (--list[result] == 0)
            list.RemoveAt(index);

        count--;
        return result;
    }

    public int Size() {
        return count;
    }

    public T PeekFirst() {
        if (Size() == 0) return default(T);
        return list.Keys[0];
    }

    public T PeekLast() {
        if (Size() == 0) return default(T);
        int index = list.Count - 1;
        return list.Keys[index];
    }
}