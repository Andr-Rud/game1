using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    abstract class Spell: IMagic
    {
        private int _mana_min;
        private bool _verbal_component;
        private bool _motor_component;
       public Spell(int mana_min, bool verbal_component, bool motor_component)//для заклинаний и артефактов, где не надо передавать некоторые их параметров(компоненты допустим), просто сделать констукторы под заклинание
        {
            _mana_min = mana_min;
            _verbal_component = verbal_component;
            _motor_component = motor_component;
        }
        public int Get_Mana_Min()
        {
            return _mana_min;
        }
        public bool Get_Verbal_Component()
        {
            return _verbal_component;
        }
        public bool Get_Motor_Component()
        {
            return _motor_component;
        }
        public void Set_Mana_Min(int mana_min)
        {
            _mana_min = mana_min;
        }
        public void Set_Verbal_Component(bool verbal_component)
        {
            _verbal_component = verbal_component;
        }
        public void Set_Motor_Component(bool motor_component)
        {
            _motor_component = motor_component;
        }
        public abstract void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint impact_force);
    }
}
