using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    class Light : ISwitchable
    {
        private bool status;

        public void SwitchOn()
        {
            status = true;
        }

        public void SwitchOff()
        {
            status = false;
        }
    }
}
