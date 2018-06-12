using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heloo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];
            //Console.WriteLine("Witaj Adamie Kosyl" + name);
            foreach (var item in args)
            {
                Console.WriteLine("Witaj  " + item);
            }
        }
    }
}
