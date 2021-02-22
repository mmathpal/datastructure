﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.StackImpl
{
    public class StackUsingArray<T> : IEnumerable<T>
    {
        //the aray of items contained in the stack. Initialized to length to 0
        //will grow as needed during push
        T[] _items = new T[0];

        //the current number of items in the stack
        int _size;

        public void Push(T item)
        {
            //_size = 0 - first push
            //_size == length - growth boundary
            if(_size == _items.Length)
            {
                //initial size to 4, otherwise double the boundary
                int newLength = _size == 0 ? 4 : _size * 2;

                //allocate, copy and assign the new aray
                T[] newArray = new T[newLength];
                _items.CopyTo(newArray, 0);
                _items = newArray;
            }
            _items[_size] = item;
            _size++;
        }

        public T Pop()
        {
            if(_size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            
            _size--;
            return _items[_size];
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _items[_size - 1];
        }

        public int Count
        {
            get
            {
                return _size;
            }
        }

        public void Clear()
        {
            _size = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = _size - 1; i >= 0; i-- )
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
