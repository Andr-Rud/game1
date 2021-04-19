using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    class Frog_Legs_Decort : Artefact
    {
        public Frog_Legs_Decort() : base(0, false){}
        public override void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint impact_force)
        {
            if(a.Get_Condition() == "poisoned")
            {
                a.Set_Condition(Character.Condition.NORMAL);
            }
        }
    }
}
