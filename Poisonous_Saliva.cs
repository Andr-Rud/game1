using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassCharacter
{
    class Poisonous_Saliva : Artefact
    {
        private Character _a;
        public Poisonous_Saliva (uint artefact_power_now, Character a) : base(artefact_power_now, true) {
            _a = a;
        }
        public override void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint artefact_power)
        {
            if ((a.Get_Condition() == "normal") || (a.Get_Condition() == "weakened"))
            {
                a.Set_Condition(Character.Condition.POISONED);
            }
            Thr1();
        }
        private void Do1()
        {
            while ((_a.Get_Health_now() >= this.Get_Artefact_power())&&(_a.Get_Condition() == "poisoned"))
            {
                Thread.Sleep(600);
                _a.Set_Health_now(_a.Get_Health_now() - this.Get_Artefact_power());
            }
        }
        private void Thr1()
        {
            Thread t1 = new Thread(this.Do1);
            t1.Start();
        }
    }
}
