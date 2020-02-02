using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lesson23
{
    public static class Convert
    {
        public static decimal ConvertMoney(decimal amount, double coefficient)
        {
            
           return (decimal)((double)amount * coefficient);
        }
    }
}
