using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    abstract class Spell: IMagic
    {
        private int mana_min;
        private bool verbal_component;
        private bool motor_component;
        public abstract void To_perform_a_magical_effect(Character a, int impact_force);
    }
}
