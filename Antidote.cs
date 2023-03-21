using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    class Antidote : Spell
    {
        public Antidote(bool verbal_component, bool motor_component) : base(30, verbal_component, motor_component) { }// Конструктор переделать под конкретное заклинание
        public override void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint k)//дописать
        {
            if (b.Get_Mana_Now() >= 30 && a.Get_Condition() == "poisoned")
            {
                a.Set_Condition(Character.Condition.WEAKENED);
                b.Set_Mana_Now(b.Get_Mana_Now() - 30);
            }
        }
    }
}
