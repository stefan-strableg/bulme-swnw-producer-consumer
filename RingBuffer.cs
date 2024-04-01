using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulme_swnw_producer_consumer
{
    internal class RingBuffer<T>
    {
        private long _begin;
        private long _end;

        private T[] _data;

        public RingBuffer(uint size)
        {
            _data = new T[size];
            _begin = 0;
            _end = 1;
        }

        public bool Put(T item)
        {
            if (isFull())
            {
                return false;
            }

            _data[_end] = item;
            _end = (_end+1) % _data.Length;
            return true;
        }

        public T Get()
        {
            if (isEmpty())
            {
                return default(T);
            }

            T ret = _data[_begin];
            _begin = (_begin +1) % _data.Length;
            return ret;

        }

        public void Clear()
        {
            Array.Clear(_data);
        }

        public bool isEmpty()
        {
            return _end == (_begin + 1 ) % _data.Length;
        }

        public bool isFull()
        {
            return _end == _begin;
        }

        public long Capacity()
        {
            return _data.Length;
        }

        public long Length()
        {
            if (_begin < _end)
            {
                return _end-1 - _begin;
            }
            else
            {
                return _end + (_data.Length - _begin);
            }
        }
    }
}
