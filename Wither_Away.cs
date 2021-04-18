﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    class Wither_Away : Spell
    {
        public Wither_Away(bool verbal_component, bool motor_component) : base(85, verbal_component, motor_component) { }
        public override void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint k)
        {
            if (b.Get_Mana_Now() >= 85 && a.Get_Condition() == "paralyzed")
            {
                a.Set_Condition(Character.Condition.WEAKENED);
                a.Set_Health_now(1);
                b.Set_Mana_Now(b.Get_Mana_Now() - 85);
            }
        }
    }
}
