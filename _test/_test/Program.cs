using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _test
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 msg = new Class1() { Text = "Hello World!" };
            Console.WriteLine("hello world");
            Console.WriteLine(msg.Text);

            Console.ReadKey();
        }
    }
}
