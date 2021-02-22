using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.DynamicArrayImpl
{
    public class DynamicArrayImpl<T> : IEnumerable<T>
    {
        private int _size;

        T[] dynArr;

        public DynamicArrayImpl()
        {
            _size = 0;

            dynArr = new T[_size];
        }

        public DynamicArrayImpl(int size)
        {
            _size = size;

            dynArr = new T[_size];
        }

        public int Size()
        {
            return _size;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public T GetItem(int index)
        {
            if(index > _size || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return dynArr[index];
        }

        public void SetItemAt(int index, T item)
        {
            if(index > _size || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            dynArr[index] = item;
        }

        public void Clear()
        {
            _size = 0;
        }

        public void AddItem(T item)
        {
            if (_size >= dynArr.Length)
            {
                int len = _size == 0 ? 4 : _size * 2;

                T[] tmpArray = new T[len];
                dynArr.CopyTo(tmpArray, 0);

                dynArr = tmpArray;
            }

            dynArr[_size++] = item;
            _size++;
        }

        public bool RemoveItem(T item)
        {
            for(int i = 0; i < dynArr.Length; i++)
            {
                if(dynArr[i].Equals(item))
                {
                    return RemoveItemAt(i);
                }
            }
            return false;
    
        }

        public bool RemoveItemAt(int index)
        {
            if(index > _size || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            T[] tmpArr = new T[dynArr.Length - 1];
            
            for (int i = 0, j = 0; i < dynArr.Length; i++, j++)
            {
                if(i == index)
                {
                    j--;
                }
                else
                {
                    tmpArr[j] = dynArr[i];
                }
            }
            dynArr = tmpArr;
            _size--;
            return true;
        }

        public int IndexOf(T item)
        {
            for(int i = 0; i < _size; i++)
            {
                if (dynArr[i].Equals(item)) return i;
            }
            return -1;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i =0; i < _size; i++)
            {
                yield return dynArr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
