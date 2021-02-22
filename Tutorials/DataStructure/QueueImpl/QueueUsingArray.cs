using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.QueueImpl
{
    public class QueueUsingArray<T> : IEnumerable<T>
    {
        //the aray of items contained in the queue. Initialized to length to 0
        //will grow as needed during enqueu

        T[] _items = new T[0];

        //the current number of items in the queue
        int _size = 0;

        public void Enqueue(T item)
        {
            if(_size == _items.Length)
            {
                //when the first item is added then update the array size to 4 else double the size
                int newLength = _size == 0 ? 4 : _size * 2;

                T[] newArray = new T[newLength];
                _items.CopyTo(newArray, 0);

                _items = newArray;
            }
            _items[_size] = item;
            _size++;
        }

        public void Dequeue(T item)
        {
            if(_size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T[] newArray = new T[_size - 1];
            Array.Copy(_items, 1, newArray, 0, _size - 1);
            _items = newArray;
            _size--;
        }

        public T Peek()
        {
            if(_size == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[0];
        }

        public int Count()
        {
            return _size;
        }

        public void Clear()
        {
            _size = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < _size; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
