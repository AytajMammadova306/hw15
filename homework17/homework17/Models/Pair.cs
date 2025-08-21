using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace homework17.Models
{
    internal class Pair<T, U> where T: INumber<T>
    {
        //public static
        public T Key {  get; set; }
        public U Value { get; set; }
        public static Pair<T, U>[] Pairs = new Pair<T, U>[0];
        public U this[ T index]
        {
            get
            {
                foreach (Pair<T, U> pair in Pairs)
                {
                    if (pair.Key == index)
                        return pair.Value;
                }
                return default;
            }
            set
            {
                foreach (Pair<T, U> pair in Pairs)
                {
                    if (pair.Key == index)
                    {
                        pair.Value = value;
                        return;
                    }
                }
                Console.WriteLine("value not found");

            }
        }
        public static void Add (Pair<T,U> pair)
        {
            int count = 0;
            foreach (Pair<T,U>  p in Pairs)
            {
                if (p.Key == pair.Key)
                    count++;
            }
            if (count == 0)
            {
                Array.Resize(ref Pairs, Pairs.Length+1);
                Pairs[Pairs.Length-1] = pair;
            }
        }
        public static void PrintInfo()
        {
            foreach (Pair<T,U> p in Pairs)
            {
                Console.WriteLine($"Key:{p.Key}, Value:{p.Value}");
            }
        }
    }
}
