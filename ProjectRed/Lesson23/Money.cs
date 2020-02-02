using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lesson23
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Unit { get; set; }

        private static double coeff = 1.25;
        
        public Money(decimal amount, string unit)
        {
            Amount = amount;
            Unit = unit;
        }

        public static Money operator +(Money a, Money b)
        {
            decimal convertedB;

            if (a.Unit != b.Unit)
            { 
                if (a.Unit == "RU")
                {
                    convertedB = Convert.ConvertMoney(b.Amount, coeff);
                }
                else
                {
                    convertedB = Convert.ConvertMoney(b.Amount, 1 / coeff);
                }
            }
            else
            {
                convertedB = b.Amount;
            }

            return new Money(a.Amount + convertedB, a.Unit);
        }

        public static bool operator ==(Money a, Money b)
        {
           return a.Amount == b.Amount && a.Unit == b.Unit;
        }

        public static bool operator !=(Money a, Money b)
        {
            return a.Amount != b.Amount || a.Unit != b.Unit;
        }

    }
}
