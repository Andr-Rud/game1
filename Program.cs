using System;
using System.Threading;

namespace ClassCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
                Console.WriteLine("Текущее здоровье " + pers1.Get_Name() + " : " + pers1.Get_Health_now().ToString());
            }
            Staff_Lightning posoh = new Staff_Lightning(30, 40);
            for (int i = 0; i < 17; ++i)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Текущая мощность посоха: " + posoh.Get_Artefact_power());
                if (posoh.Get_Artefact_Power_Max() == posoh.Get_Artefact_power())
                {
                    Console.WriteLine("Посох заряжен на 100 % !!!");
                }
            }
            */

            Character worker_John = new Character("worker John", Character.Condition.NORMAL, Character.Race.ORC, true, true, Character.Gender.MALE, 35, 150, 130, 30);
            Character old_queen = new Character("old queen", Character.Condition.PARALYZED, Character.Race.PERSON, true, false, Character.Gender.FEMALE, 92, 100, 50, 200);
            Character dark_knight = new Character("dark knight", Character.Condition.NORMAL, Character.Race.PERSON, false, true, Character.Gender.MALE, 40, 100, 100, 70);
            Character_With_Magic joker = new Character_With_Magic("joker", Character_With_Magic.Condition.NORMAL, Character_With_Magic.Race.ELF, true, true, Character_With_Magic.Gender.MALE, 29, 80, 80, 20, 300, 300);
            Character_With_Magic old_hermit = new Character_With_Magic("old hermit", Character_With_Magic.Condition.NORMAL, Character_With_Magic.Race.GOBLIN, true, true, Character_With_Magic.Gender.MALE, 50, 100, 90, 150, 400, 400);
            Character hunter = new Character("hunter", Character.Condition.NORMAL, Character.Race.ELF, true, true, Character.Gender.MALE, 46, 100, 100, 80);
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(worker_John.ToString());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(old_queen.ToString());
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(dark_knight.ToString());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(joker.ToString());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(old_hermit.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(hunter.ToString());
            Console.ResetColor();

            Armor heavy_armor = new Armor(true, true, dark_knight, 10);
            Armor light_armor = new Armor(true, true, hunter, 5);
            Staff_Lightning emerald_staff = new Staff_Lightning(40, 40);
            Frog_Legs_Decort f_legs = new Frog_Legs_Decort();


        }
    }
}
