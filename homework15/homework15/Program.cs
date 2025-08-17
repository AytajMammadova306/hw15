using homework15.Models.Helpers;

namespace homework15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt();
            list.Add(6);
            Console.WriteLine(list[6]);
            Console.WriteLine(list.Contains(6));
            Console.WriteLine(list.Contains(7));
            list.AddRange(7, 8, 9,10);
            //Console.WriteLine(list.Sum());
            //list.Remove(10);
            //Console.WriteLine(list);
            list.RemoveRange(5,10);
            Console.WriteLine(list.Sum());
            //Console.WriteLine(list);
            
        }
    }
}
