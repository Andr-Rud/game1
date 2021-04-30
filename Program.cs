using System;
using System.Threading;

namespace ClassCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            // initializing characters and outputing information about them

            Console.WriteLine("Long time ago there were some heros who lived peacfully in a distant land... But everything changed when the joker decided to fiscinate the kingdom. The brave knight come to help the old queen...");
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

            // initializing spells and artifacts

            Staff_Lightning emerald_staff = new Staff_Lightning(20, 20);
            Frog_Legs_Decort f_legs = new Frog_Legs_Decort();
            Add_Health heal = new Add_Health(true, true);
            Basilisk_Eye b_eye = new Basilisk_Eye();
            Wither_Away w_away = new Wither_Away(true, true);
            Cure cure = new Cure(true, true);

            joker.Pick_Up_An_Artefact(emerald_staff);
            joker.Learn(cure);
            joker.Pick_Up_An_Artefact(b_eye);
            old_hermit.Learn(heal);
            old_hermit.Learn(w_away);


            // the main story

            Console.Write("Evil joker is going to hit the knight with emerald staff by ");
            int hp = Console.Read();
            emerald_staff.To_perform_a_magical_effect(dark_knight, joker, (uint)(hp));
            Console.WriteLine($"And the dark knight lost { dark_knight.Get_Health_max() - dark_knight.Get_Health_now() } hp");
            uint old_health = dark_knight.Get_Health_now();
            old_hermit.Tell(heal, dark_knight, 20);
            Console.WriteLine($"But the old hermit healed the dark knight by {dark_knight.Get_Health_now() - old_health }");
            Console.WriteLine("So the joker is going to restore his strength...");
            for(int i = 0; i < 20; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Current staff power: {emerald_staff.Get_Artefact_power()}");
                if(emerald_staff.Get_Artefact_power() == emerald_staff.Get_Artefact_Power_Max())
                {
                    Console.WriteLine("The staff is full powered!");
                }
            }
            Console.WriteLine("...and paralized worker John with cure spell");
            joker.Tell(cure, worker_John, 20);
            Console.WriteLine($"Worker John is {0}", worker_John.Get_Condition());
            Console.WriteLine("Then hermit learned curing and attacked joker so joker tried to use wither away spell but lost his knowledge about it");
            old_hermit.Learn(cure);
            old_hermit.Tell(cure, joker, 20);
            joker.Forget(cure);
            Console.WriteLine("And then vilian left the kingdom and nobody ever heard of him.........");
        }
    }
}
