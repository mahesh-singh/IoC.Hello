using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var clarkson = new Clarkson();

            clarkson.ShoutSomthing();


            Console.ReadKey();
        }
    }
}
