using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.LinkedListImpl
{
    public class DoublyLinkedList<T> : ICollection<T>
    {
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }


        public void AddFirst(T item)
        {
            AddFirst(new DoublyLinkedListNode<T>(item));
        }

        private void AddFirst(DoublyLinkedListNode<T> node)
        {
            DoublyLinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
        }

        public void AddLast(T item)
        {
            AddLast(new DoublyLinkedListNode<T>(item));
        }

        private void AddLast(DoublyLinkedListNode<T> node)
        {
            if(Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
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
                else
                {
                    Head.Previous = null;
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
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }
                Count--;
            }
        }

        public int Count { get; private set; }

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
            DoublyLinkedListNode<T> current = Head;
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
            DoublyLinkedListNode<T> current = Head;
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
            DoublyLinkedListNode<T> previous = null;
            DoublyLinkedListNode<T> current = Head;

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
                        else
                        {
                            current.Next.Previous = previous;
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
            DoublyLinkedListNode<T> current = Head;
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
