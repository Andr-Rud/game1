using System;
using System.Threading;
namespace ClassCharacter
{
    class Prog
    {
        static void Main(string[] args)
        {
            Character pers1 = new Character("A", Character.Condition.NORMAL, Character.Race.ELF, true, true, Character.Gender.MALE, 100, 100, 78, 1900);
            Console.WriteLine(pers1.ToString());
            Character_With_Magic pers2 = new Character_With_Magic("B", Character.Condition.NORMAL, Character.Race.ELF, true, true, Character.Gender.MALE, 100, 100, 10000, 19000, 400000, 5000000);
            Console.WriteLine(pers2.ToString());
           // Console.WriteLine(pers1.Comparison_by_experience(pers1, pers2));
            Armor ar = new Armor(true, true, pers1, 5);
            pers2.Tell(ar, pers1, 20);
            //new Thread().Start();
            for (int i = 0; i < 9; ++i)
            {
                Thread.Sleep(100);
                Console.WriteLine(pers1.Get_Health_now().ToString());
               // t1.Join();
            }
        }
    }
}
