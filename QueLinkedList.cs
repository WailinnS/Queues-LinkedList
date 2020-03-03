using System;
using System.Collections;
using System.Collections.Generic;

namespace Queues_LinkedList
{
    public class QueLinkedList<T> : IEnumerable<T> where T : IComparable
    {
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }

        public int Count { get; set; }
        public QueLinkedList ()
        {
            Head = null;
            Count = 0;
        }

        public void AddFirst(T data)
        {
            LinkedListNode<T> temp = new LinkedListNode<T>(data, ownList: this);
            if(Head == null)
            {
                Head = temp;
                Tail = Head;
                Count++;
            }
            else
            {
                temp.NextNode = Head;
                Head = temp;
                Count++;
            }
            

        }
        public void AddLast(T data)
        {
            if(Count == 0)
            {
                AddFirst(data);
            }
            else
            {
                LinkedListNode<T> current = Head;
                while(current.NextNode != null)
                {
                    current = current.NextNode;
                }
                
                current.NextNode = new LinkedListNode<T>(data,ownList:this);
                Tail = current.NextNode;
                Count++;
            }
        }

        public bool Find(T data)
        {
            LinkedListNode<T> current = Head;
            while(current.NextNode != null)
            {
                if(current.Data.Equals(data))
                {
                    return true;
                }
            }
            return false;
        }


        public bool RemoveFirst()
        {
            if(Head == null)
            {
                return false;
            }
            if(Count == 0)
            {
                return false;
            }

            Head = Head.NextNode;
            Count--;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while(current.NextNode != null)
            {
                yield return current.Data;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
