using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    public class Student
    {
        private string name;
        private int course;
        private bool grant;

        public Student()
        {
            name = "Ivan";
            course = 1;
            grant = false;
        }
            
        public Student(string name, int course, bool grant)
        {
            this.name = name;
            this.course = course;
            this.grant = grant;
        }

        public Student(string name, bool grant)
        {
            this.name = name;
            course = 1;
            this.grant = grant;
        }
    }
}
