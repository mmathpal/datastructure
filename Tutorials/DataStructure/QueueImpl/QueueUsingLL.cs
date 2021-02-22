using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.QueueImpl
{
    public class QueueUsingLL<T> : IEnumerable<T>
    {
        LinkedList<T> _list = new LinkedList<T>();

        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        public T Dequeue()
        {
            if(_list.Count == 0)
            {
                throw new InvalidOperationException("No items in the queue");
            }

            T value = _list.First.Value;

            _list.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("No items in the queue");
            }

            T value = _list.First.Value;

            return value;
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }

        public void Clear()
        {
            _list.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
