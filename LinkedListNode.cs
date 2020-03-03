using System;

namespace Queues_LinkedList
{
   public class LinkedListNode<T> where T :IComparable
    {
        public T Data { get; set; }
        public LinkedListNode<T> NextNode { get; set; }

        public QueLinkedList<T> Ownlist { get; }
        public LinkedListNode ()
        {
            Data = default;
            NextNode = null;
        }
        public LinkedListNode (T value, QueLinkedList<T> ownList)
        {
            Ownlist = ownList;
            Data = value;
        }
    }
}
