using System;
using System.Collections.Generic;
using System.Text;
namespace ClassCharacter
{
    class Character_With_Magic : Character
    {
        private int _mana_now;
        private int _mana_max;
        private int _force;
        public Character_With_Magic(string name, Condition condition, Race race, bool ability_to_speak, bool ability_to_move, Gender gender, int age, int health_max, int health_now, int experience, int mana_max, int mana_now, int force)
            : base(name, condition, race, ability_to_speak, ability_to_move, gender, age, health_max, health_now, experience)
        {
            Set_Mana_Max(mana_max);
            Set_Mana_Now(mana_now);
            Set_Force(force);
        }
        public void Set_Mana_Max(int mana_max)
        {
            _mana_max = mana_max;
        }
        public void Set_Mana_Now(int mana_now)
        {
            _mana_now = mana_now;
        }
        public int Get_Mana_Max()
        {
            return _mana_max;
        }
        public int Get_Mana_Now()
        {
            return _mana_now;
        }
        public int Get_Force(){
            return _force;
        }
        public void Set_Force(int force)
        {
            _force = force;
        }
        public override string ToString()
        {
            return base.ToString() + " mana_max: " + _mana_max +'\n' + " mana_now: " + _mana_now + '\n';
        } 
        public void Tell(Spell a,Character b)
        {
            a.To_perform_a_magical_effect(b, _force);
        }
    }
}
