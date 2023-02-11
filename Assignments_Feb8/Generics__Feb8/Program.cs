using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics__Feb8
{
    internal class Program
    {
        public class GenericExample
        {
            public void add<T>(T param1, T param2)
            {
                Console.WriteLine($"parameter1:{param1}, parameter2:{param2}");
            }
        }
        static void Main(string[] args)
        {
            GenericExample genericExample = new GenericExample();
            genericExample.add(1,2);
            genericExample.add("Hello","World");
            Console.ReadLine();
        }
    }
}
