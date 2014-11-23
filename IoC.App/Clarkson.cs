using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IoC.App
{
    class Clarkson
    {
        internal void ShoutSomthing()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 20)
                {
                    Console.WriteLine("Good evening!");
                }
                else if (DateTime.Now.Hour >= 20)
                {
                    Console.WriteLine("Get out of the way!"); 
                }
            }
            else 
            {
                Console.WriteLine("You're wrong!");
            }

        }
    }
}
