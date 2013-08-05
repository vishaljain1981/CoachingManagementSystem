using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>()
            {
                {"cat",2},
                {"dog",1},
                {"llama",0},
                {"iguana",-1},
            };
            foreach (var pair in d)
            {
                Console.WriteLine("{0},{1}",pair.Key,pair.Value);
                Console.Read();
            }
        }
    }
}
