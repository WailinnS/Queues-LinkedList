using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_LinkedList
{
    class Queue<T>
    {
        public int Count { get => list.Count; }
        private QueLinkedList<T> list;
        
        public Queue()
        {
            list = new QueLinkedList<T>();
        }
    }
}
