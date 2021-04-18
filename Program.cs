using System;
using System.Threading;
namespace ClassCharacter
{
    class Prog
    {
        static void Main()
        {
            Character pers1 = new Character("A", Character.Condition.NORMAL, Character.Race.ELF, true, true, Character.Gender.MALE, 100, 100, 78, 1900);
            Console.WriteLine(pers1.ToString());
           // Console.ResetColor();
            Character_With_Magic pers2 = new Character_With_Magic("B", Character.Condition.NORMAL, Character.Race.ELF, true, true, Character.Gender.MALE, 100, 100, 10000, 19000, 400000, 5000000);
            Console.WriteLine(pers2.ToString());
           // Console.ResetColor();
            Console.WriteLine(pers1.Comparison_by_experience(pers1, pers2));
            Armor ar = new Armor(true, true, pers1, 5);
            pers2.Tell(ar, pers1, 2);
            for (int i = 0; i < 9; ++i)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Текущее здоровье "+pers1.Get_Name() + " : " +pers1.Get_Health_now().ToString());
            }
            Staff_Lightning posoh = new Staff_Lightning(30,40);
            for (int i = 0; i < 17; ++i)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Текущая мощность посоха: " + posoh.Get_Artefact_power());
                if (posoh.Get_Artefact_Power_Max() == posoh.Get_Artefact_power())
                {
                    Console.WriteLine("Посох заряжен на 100 % !!!");
                }
            }
        }
    }
}
