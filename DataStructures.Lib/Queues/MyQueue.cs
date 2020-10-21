using System;
using System.Collections;
using System.Linq;

namespace DataStructures.Lib.Queues
{
    public class MyQueue : IEnumerable
    {
        private object[] _array;
        private int _capacity = 0;
        public int Count => _array.Length;

        public MyQueue()
        {
            _array = new object[_capacity];
        }

        public void Enqueue(object obj)
        {
            _capacity++;

            object[] oldArray = _array;
            _array = new object[_capacity];

            Array.Copy(oldArray, 0, _array, 0, oldArray.Length);
            _array[_capacity - 1] = obj;
        }

        public object Dequeue()
        {
            _capacity--;

            object[] oldArray = _array;
            _array = new object[_capacity];

            Array.Copy(oldArray, 1, _array, 0, Count);

            return oldArray[0];
        }

        public object Peek()
        {
            return _array[0];
        }

        public bool Contains(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (obj.Equals(_array[i])) return true;
            }

            return false;
        }

        public void Clear()
        {
            _capacity = 0;
            _array = new object[_capacity];
        }

        public IEnumerator GetEnumerator()
        {
            return _array.AsEnumerable().GetEnumerator();
        }
    }
}
