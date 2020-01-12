using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed
{
    public class Match
    {
        public string GetResult(int ownerGoals, int guestGoals)
        {
            if (ownerGoals < 0 || guestGoals <0)
            {
                throw new ArgumentException("Arguments are incorrect.");
            }
            if (ownerGoals > guestGoals)
            {
                return "win owner";
            }
            else if (ownerGoals < guestGoals)
            {
                return "guest win";
            }
            else
            {
                return "draw";
            }
        }

    }
}
