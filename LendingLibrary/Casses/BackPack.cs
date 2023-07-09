using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary.Casses
{
    public class BackPack<T> : IBag<T>
    {
        private List<T> list;

        public BackPack()
        {
            list = new List<T>();
        }
        public void Pack(T item)
        {
            if (item == null)
            {
                return;
            }
            list.Add(item);
        }

        public T Unpack(int index)
        {
            var item = list[index];
            list.RemoveAt(index);
            return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public void print()
        {
            foreach (var item in list)
            {
               Console.WriteLine(item);

            }
        }
    }
}
