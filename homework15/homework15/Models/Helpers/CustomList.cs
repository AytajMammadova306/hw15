using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homework15.Models.Helpers
{
    internal class CustomList<T> where T:INumber<T>
    {
        private T[] arr = new T[4];
        public int Capacity = 4;
        public int Count = 0;
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public void Add(T item)
        {
            if (Capacity == Count)
            {
                Array.Resize(ref arr, Capacity * 2);
                Capacity *= 2;
            }
            arr[Count]=item;
            Count++;
        }
        public bool Contains(T item)
        {
            foreach (T i in arr)
            {
                if (i == item)
                    return true;
            }
            return false;
        }
        public void AddRange(params T[] items)
        {
            if (Capacity < Count+items.Length)
            {
                Array.Resize(ref arr, Capacity * 2);
                Capacity *= 2;
            }
            for (int i = 0; i < items.Length; i++)
            {
                arr[i + Count] = items[i];
            }
            Count+=items.Length;
        }
        public void Remove(T item)
        {
            if (Count - 1 < Capacity / 2)
            {
                Capacity/=2;
            }
            T[] newarr=new T[Capacity];
            int j = 0;
            for (int i = 0; i < Count; i++)
            {
                if (arr[i] != item)
                {
                    newarr[j] = arr[i];
                    j++;
                }
            }
            arr = newarr;
            Count--;
        }
        public void RemoveRange(params T[] items)
        {
            if (Count - items.Length < Capacity / 2)
            {
                Capacity /= 2;
            }
            T[] newarr = new T[Capacity];
            int j = 0;
            for (int i = 0; i < Count; i++)
            {
                int count = 0;
                foreach (T k in items)
                {
                    if (arr[i] != k)
                    {
                        count++;
                    }
                }
                if (count == items.Length)
                {
                    newarr[j] = arr[i];
                    j++;
                }
            }
            arr = newarr;
            Count -= items.Length;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Count - 1; i++)
            {
                sb.Append($"{arr[i]}, ");
            }
            sb.Append(arr[Count - 1]);
            return sb.ToString();
        }
    }
}
