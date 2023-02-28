using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground
{
    public class OrderedList<T> where T : IComparable<T>
    {
        public List<T> _data = new List<T>();

        public void Add(T element)
        {
            if (_data.Count() == 0)
            {
                _data.Add(element);
                return;
            }

            var currentIndex = 0;
            while (currentIndex < _data.Count() && _data[currentIndex].CompareTo(element) < 0)
            {
                currentIndex++;
            }

            _data.Insert(currentIndex, element);
        }

        public T Get(int index)
        {
            return default;
        }

        public void PrintData()
        {
            foreach (var element in _data)
            {
                Console.WriteLine( element );
            }
        }
    }
}
