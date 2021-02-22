using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.LinkedListImpl
{
    public class SinglyLinkedList<T> : ICollection<T>
    {
        public SinglyLinkedListNode<T> Head { get; private set; }
        public SinglyLinkedListNode<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            AddFirst(new SinglyLinkedListNode<T>(item));
        }

        private void AddFirst(SinglyLinkedListNode<T> node)
        {
            SinglyLinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T item)
        {
            AddLast(new SinglyLinkedListNode<T>(item));
        }

        private void AddLast(SinglyLinkedListNode<T> node)
        {
            if(Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;

            Count++;
  
        }

        public void RemoveFirst()
        {
            if(Count != 0)
            {
                Head = Head.Next;
                Count--;

                if(Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if(Count !=0)
            {
                if(Count == 1)
                {
                    Head = Tail = null;
                }
                else
                {
                    SinglyLinkedListNode<T> current = Head;
                    while(current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                    
                }
                Count--;
            }
        }

        

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            SinglyLinkedListNode<T> current = Head;
            while(current.Next != null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Copies the node values into the specified array
        /// </summary>
        /// <param name="array">The array to copy the linked list values to</param>
        /// <param name="arrayIndex">The index in the array to start copying at</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            SinglyLinkedListNode<T> current = Head;
            while(current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Removes the first occurance of the item from the list(searching from head to tail)
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if the item was found and removed, false otherwise</returns>
        public bool Remove(T item)
        {
            SinglyLinkedListNode<T> previous = null;
            SinglyLinkedListNode<T> current = Head;

            /*
             1: Empty List: Do nothing
             2: Single Node: (previous is null)
             3: Many nodes:
                a. node to remove is the first node
                b. node to remove is the middle or last
             */
            while(current!=null)
            {
                if(current.Value.Equals(item))
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;

                        //it was the end - so update Tail
                        if(current.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                
                previous = current;
                current = current.Next;
                
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            SinglyLinkedListNode<T> current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
