using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningsIntroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine($"Hello: {args.Length}");
            }

            for (var i = 0; i<args.Length; i++)
            {
                Console.WriteLine($"Parameter {i+1} er: {args[i]}");
            }
        }
    }
}
