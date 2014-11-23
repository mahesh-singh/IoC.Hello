using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IoC.App
{
    public class Autocue
    {
        public string GetSomethingIntelligent()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 20)
                {
                    return "Good evening!";
                }
                else if (DateTime.Now.Hour >= 20)
                {
                    return "Get out of the way!";
                }
            }
            return "You're wrong!";
        }
    }
}
