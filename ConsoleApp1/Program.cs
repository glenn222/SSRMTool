using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String builder pass: " + TestStaircase.TestStringBuilder());
            Console.WriteLine("Map calculator: " + TestDeviceMap.TestExpressionOutput());
            Console.ReadKey();
        }
    }
}
