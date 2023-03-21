using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    class Poisonous_Saliva : Artefact
    {
        public Poisonous_Saliva(uint artefact_power) : base(artefact_power, true) { }
        public override void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint impact_force)
        {
            if ((a.Get_Condition() == "normal")||(a.Get_Condition() == "weakened"))
            {
                a.Set_Condition(Character.Condition.POISONED);
            }
            //............................ потоки
        }
    }
}
