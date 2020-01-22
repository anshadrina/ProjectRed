using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    public class TV
    {
        private short currentChanel = 0;
        private short minChanel = 0;

        public short CurrentChannel
        {
            get
            {
                return currentChanel;
            }
        }

        public void NextChanel()
        {
            if (currentChanel < short.MaxValue)
            {
                currentChanel++;
            }
            else
            {
                currentChanel = minChanel;
            }
        }

        public void PreviousChanel()
        {
            if (currentChanel > minChanel)
            {
                currentChanel--;
            }
            else
            {
                currentChanel = short.MaxValue;
            }
        }
        public void ChangeChanel(short chanel)
        {
            if (chanel >= minChanel && chanel <= short.MaxValue)
            {
                currentChanel = chanel;
            }
            else 
            {
                throw new Exception("Chanel could not be negative or bigger than " + short.MaxValue); 
            }
        }

    }
}
