using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // static class that can't be instanced
    static internal class UsefulTools
    {
        public static void Sayhello(string name)
        {
            Console.WriteLine("Hello "+ name);
        }
    }
}
