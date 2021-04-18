using System;
using System.Collections.Generic;
using System.Text;
namespace ClassCharacter
{
    class Character_With_Magic : Character
    {
        private uint _mana_now;
        private uint _mana_max;
        private Dictionary<string, bool> _knowledge = new Dictionary<string, bool>(6);
        public Character_With_Magic(string name, Condition condition, Race race, bool ability_to_speak, bool ability_to_move, Gender gender, uint age, uint health_max, uint health_now, uint experience, uint mana_max, uint mana_now)
            : base(name, condition, race, ability_to_speak, ability_to_move, gender, age, health_max, health_now, experience)
        {
            Set_Mana_Max(mana_max);
            Set_Mana_Now(mana_now);
            _knowledge.Add("add_health", false);
            _knowledge.Add("antidote", false);
            _knowledge.Add("cure", false);
            _knowledge.Add("revive", false);
            _knowledge.Add("armor", false);
            _knowledge.Add("wither_away", false);
        }
        public Character_With_Magic():base("Unknown", Condition.NORMAL, Race.PERSON, true, true, Gender.MALE, 100, 100, 100, 0)
        {
            Set_Mana_Max(100);
            Set_Mana_Now(100);
            _knowledge.Add("add_health", false);
            _knowledge.Add("antidote", false);
            _knowledge.Add("cure", false);
            _knowledge.Add("revive", false);
            _knowledge.Add("armor", false);
            _knowledge.Add("wither_away", false);
        }
        public void Set_Mana_Max(uint mana_max)
        {
            if (mana_max < this.Get_Mana_Now())
            {
                _mana_now = mana_max;
            }
            _mana_max = mana_max;
        }
        public void Set_Mana_Now(uint mana_now)
        {
            if (mana_now > this.Get_Mana_Max())
            {
                _mana_now = this.Get_Mana_Max();
            }
            _mana_now = mana_now;
        }
        public uint Get_Mana_Max()
        {
            return _mana_max;
        }
        public uint Get_Mana_Now()
        {
            return _mana_now;
        }
        public override string ToString()
        {
            return base.ToString() + " mana_max: " + _mana_max + '\n' + " mana_now: " + _mana_now + '\n';
        }
        public void Tell(Spell a, Character b, uint k)
        {
            a.To_perform_a_magical_effect(b, this, k);
        }
        public void Learn(Spell a){
            if (a.GetType().Name == "Armor")
            {
                _knowledge["armor"] = true;
            }
            if (a.GetType().Name == "Cure")
            {
                _knowledge["cure"] = true;
            }
            if (a.GetType().Name == "Add_Health")
            {
                _knowledge["add_health"] = true;
            }
            if (a.GetType().Name == "Wither_Away")
            {
                _knowledge["wither_away"] = true;
            }
            if (a.GetType().Name == "Revive")
            {
                _knowledge["revive"] = true;
            }
            if (a.GetType().Name == "Antidote")
            {
                _knowledge["antidote"] = true;
            }
        }
        public void Forget(Spell a)
        {
            if (a.GetType().Name == "Armor")
            {
                _knowledge["armor"] = false;
            }
            if (a.GetType().Name == "Cure")
            {
                _knowledge["cure"] = false;
            }
            if (a.GetType().Name == "Add_Health")
            {
                _knowledge["add_health"] = false;
            }
            if (a.GetType().Name == "Wither_Away")
            {
                _knowledge["wither_away"] = false;
            }
            if (a.GetType().Name == "Revive")
            {
                _knowledge["revive"] = false;
            }
            if (a.GetType().Name == "Antidote")
            {
                _knowledge["antidote"] = false;
            }
        }
    }
}
