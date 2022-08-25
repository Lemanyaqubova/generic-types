using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class CustomClass<T>
    {
        T[] _arr;
        int _count;
        public int Capacity { get; set; } = 3;
        public int Count { get => _arr.Length - _count; }
        public CustomClass()
        {
            _arr = new T[0];
        }
        public T this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Add(T value)
        {
            if (_count== 0)
            {
                Array.Resize(ref _arr, _arr.Length + Capacity);
                _count = Capacity;
            }
            _arr[Count] = value;
            _count--;

        }
        public void Clear()
        {
            _count= 0;
            _arr = new T[0];
        }
        public bool Exist(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(item, _arr[i]))
                    return true;
            }

            return false;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(_arr[i], item))
                    return i;
            }

            throw new KeyNotFoundException();
        }
        public int LastIndexOf(T item)
        {
            for (int i = _arr.Length - 1; i >= 0; i--)
            {
                if (object.Equals(_arr[i], item))
                    return i;
            }
            throw new KeyNotFoundException();
        }  
    }
}
