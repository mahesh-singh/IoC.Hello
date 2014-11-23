using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IoC.App
{
    public class Clarkson
    {
        public void ShoutSomthing()
        {
            var autocue = new Autocue();
            var message = autocue.GetSomethingIntelligent();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);

        }
    }
}
