using System;

namespace ClassCharacter
{
    class Prog
    {
        static void Main(string[] args)
        {
            Character pers1 = new Character("A", Character.Condition.NORMAL, Character.Race.ELF, true, true, Character.Gender.MALE, 100, 100, 78, 1900);
            Console.WriteLine(pers1.ToString());
            Character_With_Magic pers2 = new Character_With_Magic("B", Character.Condition.NORMAL, Character.Race.ELF, true, true, Character.Gender.MALE, 100, 100, 78, 19000, 400, 500,5);
            Console.WriteLine(pers2.ToString());
            Console.WriteLine(pers1.Comparison_by_experience(pers1, pers2));
        }
    }
}
