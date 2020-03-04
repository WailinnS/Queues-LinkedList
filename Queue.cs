using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_LinkedList
{
    class Queue<T> where T: IComparable
    {
        public int Count { get => list.Count; }
        private QueLinkedList<T> list;
        
        public Queue()
        {
            list = new QueLinkedList<T>();
        }
        public void Enqueue(T data)
        {
            list.AddLast(data);
        }

        public T Dequeue()
        {
            T temp = list.Head.Data;
            list.RemoveFirst();
            return temp;
        }

        public T Peek()
        {
            return list.Head.Data;
        }

        public bool IsEmpty => list.Head == null;

        public void clear()
        {
            list.Head = null;
        }
    }
}
