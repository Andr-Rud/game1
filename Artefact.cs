using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    abstract class Artefact: IMagic
    {
        private uint _artefact_power;
        private bool _renewability;
        public Artefact(uint artefact_power, bool renewability)
        {
            _artefact_power = artefact_power;
            _renewability = renewability;
        }
        public enum Bottles
        {
            BIG,
            MEDIUM,
            SMALL
        };
        public uint Get_Artefact_power()
        {
            return _artefact_power;
        }
        public bool Get_Renewability()
        {
            return _renewability;
        }
        public void Set_Artefact_power(uint artefact_power)
        {
            _artefact_power = artefact_power;
        }
        public void Set_Renewability(bool renewability)
        {
            _renewability = renewability;
        }
        public abstract void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint impact_force);

    }
}
