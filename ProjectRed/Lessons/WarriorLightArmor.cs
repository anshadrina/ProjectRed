using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    class WarriorLightArmor : Warrior
    {
        public WarriorLightArmor() : base() { }

        public WarriorLightArmor(double currentAmountLives) : base(currentAmountLives) { }

        public override void GetDamage(double damage)
        {
            CurrentAmountLives -= damage * 0.75;
        }
    }
}
