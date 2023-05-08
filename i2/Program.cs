using System;
using System.Collections;
using Microsoft.Extensions.DependencyInjection;

namespace i2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = { 1, 2, 3, 4, 5 };
            ArrayList n2 = new ArrayList { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(n1));
            Console.WriteLine(Sum(n2));
            var roc = new ReadOnlyCollection(n1);
            foreach (var n in roc)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(Sum(roc));
        }
        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }
    }

    class ReadOnlyCollection:IEnumerable
    {
        private int[] _array;

        public ReadOnlyCollection(int[] array)
        {
            _array = array; 
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        public class Enumerator:IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head=-1;

            public Enumerator(ReadOnlyCollection c)
            {
                _collection = c;
            }

            public object Current
            {
                get
                {
                    object o = _collection._array[_head];
                    return o;
                }
                
            }
            public bool MoveNext()
            {
                if (++_head<_collection._array.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                _head = -1;
            }

        }
    }


   
}
