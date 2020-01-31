using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lesson23
{
    class Names
    {
        private string[] names = { "Nik", "John", "Karl", "Petr", "Nikon" };

        public void WriteNames()
        {
            foreach (string name in names)
            {
                Console.WriteLine(name + "," + " ");
            }
        }

        public void WriteNames(char devider)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name + devider + " ");
            }
        }
    }
}
