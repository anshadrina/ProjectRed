using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    public class Warrior
    {
        private double currentAmountLives;
        private double maxAmountLives = 500;
        public double CurrentAmountLives
        {
            get
            {
                return currentAmountLives;
            }
            protected set
            {
                if (value < 0)
                    currentAmountLives = 0;
                else if (value > maxAmountLives)
                    currentAmountLives = maxAmountLives;
                else currentAmountLives = value;
            }
        }

        public Warrior()
        {
            currentAmountLives = 100;
        }

        public Warrior(double currentAmountLives)
        {
            this.currentAmountLives = currentAmountLives;
        }

        public virtual void GetDamage(double damage)
        {
            CurrentAmountLives -= damage; 
        }
    }
}
