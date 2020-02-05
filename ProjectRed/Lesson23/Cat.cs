using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lesson23
{
    class Cat
    {
        public int Hungry { get; set; }

        public Cat(int hungry)
        {
            Hungry = hungry;
        }

        

    }

    public enum Food { Fish, Milk, Meat, Mouse, Watter };
}
