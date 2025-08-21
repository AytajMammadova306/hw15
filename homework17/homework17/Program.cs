using homework17.Models;

namespace homework17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair = new Pair<int, string>
            {
                Key=1,
                Value="samebody"
            };
            Pair<int, int> pair2 = new Pair<int, int>
            {
                Key = 2,
                Value = 102
            };
            Pair<int, int> pair3 = new Pair<int, int>
            {
                Key = 2,
                Value = 102
            };
            Pair<int, string>.Add(pair);
            Pair<int, int>.Add(pair2);
            Pair<int, int>.Add(pair2);
            foreach (Pair<int, string> p in Pair<int, string>[])
            {
                Console.WriteLine($"Key:{Key}, Value:{Value}");
            }
        }
    }
}
