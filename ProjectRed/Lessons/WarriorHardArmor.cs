using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    class WarriorHardArmor : Warrior
    {
        public WarriorHardArmor() : base() { }

        public WarriorHardArmor(double currentAmountLives) : base(currentAmountLives) { }

        public override void GetDamage(double damage)
        {
            CurrentAmountLives = CurrentAmountLives - damage * 0.5;
        }
    }
}
