using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassCharacter
{
    class Armor : Spell
    {
        private Character _perc;
        private uint _time;
        public Armor(bool verbal_component, bool motor_component, Character a, uint time ) : base(0, verbal_component, motor_component) {
            _perc = a;
            _time = time;
        }// Конструктор переделать под конкретное заклинание
        public override void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint time)//дописать
        {
            if (b.Get_Mana_Now() - time * 50 >= 0)
            {
                b.Set_Mana_Now(b.Get_Mana_Now() - time * 50);
            }
            else
            {
                time = b.Get_Mana_Now() / 50;
                b.Set_Mana_Now(b.Get_Mana_Now() - time * 50);
            }
            Thr();
        }
        private void Do()
        {
            uint temp = _perc.Get_Health_now();
            for (int i = 0; i < _time * 1000; ++i)
            {
                Thread.Sleep(1);
                _perc.Set_Health_now(_perc.Get_Health_max()-1);
            }
            _perc.Set_Health_now(temp);
        } 
        private void Thr()
        {
            Thread t = new Thread(this.Do);
            t.Join();
        }
    }
}
