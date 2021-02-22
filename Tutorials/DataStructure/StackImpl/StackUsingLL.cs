using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.StackImpl
{
    public class StackUsingLL<T> : IEnumerable<T>
    {
        LinkedList<T> _list = new LinkedList<T>();

        public void Push(T item)
        {
            _list.AddFirst(item);
        }

        public T Pop()
        {
            if(_list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T value = _list.First.Value;
            _list.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T value = _list.First.Value;

            return value;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
