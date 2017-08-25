using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskLogic;

namespace TaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer("Alex", "Lomako");
            var c2 = new Customer("Alex", "Lomako");
            var c3 = new Customer("NeAlex", "NeLomako");
            var c4 = new Customer("VoobsheNeAlex", "VoobsheNeLomako");

            Console.WriteLine(c1.Compare(c2, (x, y) => x.Id > y.Id)); 


        }
    }
}
