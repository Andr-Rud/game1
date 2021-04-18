using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassCharacter
{
    class Staff_Lightning : Artefact
    {
        private uint _artefact_power_max;
        public Staff_Lightning(uint artefact_power_now, uint artefact_power_max) : base(artefact_power_now, true)
        {
            _artefact_power_max = artefact_power_max;
            Thr();
        }
        public override void To_perform_a_magical_effect(Character a, Character_With_Magic b, uint impact_force)
        {
            if (impact_force < this.Get_Artefact_power())
            {
                a.Set_Health_now(a.Get_Health_now() - impact_force);
                this.Set_Artefact_power(this.Get_Artefact_power() - impact_force);
            }
            else
            {
                a.Set_Health_now(a.Get_Health_now() - this.Get_Artefact_power());
                this.Set_Artefact_power(0);
            }
            Thr();
            
        }
        private void Do()
        {
            while (this.Get_Artefact_power()<this.Get_Artefact_Power_Max())
            {
                Thread.Sleep(1000);
                this.Set_Artefact_power(Get_Artefact_power() + 1);
            }
        }
        private void Thr()
        {
            Thread t = new Thread(this.Do);
            t.Start();
        }
        public void Set_Artefact_Power_Max(uint artefact_power_max)
        {
            if(artefact_power_max < this.Get_Artefact_power())
            {
                this.Set_Artefact_power(artefact_power_max);
            }
            _artefact_power_max = artefact_power_max;
        }
        public uint Get_Artefact_Power_Max()
        {
            return _artefact_power_max;
        }
    }
}
