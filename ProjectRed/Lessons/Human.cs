using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    abstract class Human
    {
        private string name;
        public string Name { get; set; }

        public abstract void SayHi();
    }
}
