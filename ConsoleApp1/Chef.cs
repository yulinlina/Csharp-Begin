using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chef
    {
        public virtual void makeSpecial()
        {
            Console.WriteLine("Chef is going to make cakes");
        }
    }

    class Mychef : Chef
    {
        public override void makeSpecial()
        {
            Console.WriteLine("My chef is making eggs");
        }
    }
}
