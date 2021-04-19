using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    class Cure : Spell
    {
        public  Cure(bool verbal_component, bool motor_component) : base(20, verbal_component, motor_component) { }
        public override void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint k)
        {
            if (b.Get_Mana_Now() >= 20 && a.Get_Condition() == "sick")
            {
                a.Set_Condition(Character.Condition.WEAKENED);
                b.Set_Mana_Now(b.Get_Mana_Now() - 20);
            }
        }
    }
}
