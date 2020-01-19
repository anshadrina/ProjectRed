using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed
{
    public class Functions
    {
        public int[] ChangeElements(int compareTo, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == compareTo)
                {
                    array[i] = array[i] * -1;
                }
            }
            return array;
        }

        public float GetMin(float a, float b, float c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else if (c < a && c < b)
            {
                return c;
            }
            else
            {
                throw new Exception("Something went wrong");
            }
        }

        public long GetElement(int element)
        {
            long previousElement = 0;
            long currentElement = 1;

            if (element == 1)
            {
                return previousElement;
            }
            if (element == 2)
            {
                return currentElement;
            }
           
            for (int i = 3; i <= element; i++)
            {
                long temp = previousElement + currentElement;
                previousElement = currentElement;
                currentElement = temp;
            }
            return currentElement;
        }
    }
}
