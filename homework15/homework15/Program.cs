using homework15.Models.Helpers;

namespace homework15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.AddRange(6,3,1,4,9);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //Console.WriteLine(list[6]);
            Console.WriteLine(list.Contains(6));
            //list.Remove(1);
            list.RemoveRange(6,3);
            Console.WriteLine(list);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);

        }
    }
}
