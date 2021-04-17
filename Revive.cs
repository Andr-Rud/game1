using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
     class Revive: Spell
    {
        public Revive(int mana_min, bool verbal_component, bool motor_component) : base(mana_min, verbal_component, motor_component) { }
        public  override void To_perform_a_magical_effect(Character a, int mana_min)
        {

        }
    }
}
