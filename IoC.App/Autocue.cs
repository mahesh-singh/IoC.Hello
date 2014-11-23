using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IoC.App
{
    public class Autocue
    {
        private IClock _clock;

        public string GetSomethingIntelligent()
        {
            DateTime now = _clock.Now;

            if (now.DayOfWeek == DayOfWeek.Thursday)
            {
                if (now.Hour >= 18 && DateTime.Now.Hour < 20)
                {
                    return "Good evening!";
                }
                else if (now.Hour >= 20)
                {
                    return "Get out of the way!";
                }
            }
            return "You're wrong!";
        }
    }
}
