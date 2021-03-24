using System;
using System.Collections.Generic;
using System.Text;

namespace FirstP
{
    class Сharacter
    {
        private int _index = 1;
        private string _name;
        private string _condition;
        private string _raсe;
        private bool _ability_to_speak;
        private bool _ability_to_move;
        private string _gender;
        private int _age;
        private int _health_max;//неотрицательная вел.
        private int _health_now;
        private int _experience;
        public Сharacter(string name, Condition condition, Race race, bool ability_to_speak, bool ability_to_move, Gender gender, int age, int health_max, int health_now, int experience)
        {
            _index++;
            _name = name;//+
            Set_Condition(condition);
            Set_Race(race);
            Set_Ability_to_speak(ability_to_speak);//+
            Set_Ability_to_move(ability_to_move);//+
            Set_Gender(gender);//
            Set_Age(age);//
            Set_Health_max(health_max);//
            Set_Health_now(health_now);//
            Set_Experience(experience);//
        }
        public int Get_Index()
        {
            return _index;
        }
        public string Get_Name()
        {
            return _name;
        }
        public string Get_Condition()
        {
            return _condition;
        }
        public void Set_Condition(string condition)
        {
            _condition = condition;
        }
        public string Get_Raсe()
        {
            return _raсe;
        }
        public bool Get_Ability_to_speak()
        {
            return _ability_to_speak;
        }
        public void Set_Ability_to_speak(bool ability_to_speak)
        {
            _ability_to_speak = ability_to_speak;
        }
        public bool Get_Ability_to_move()
        {
            return _ability_to_move;
        }
        public void Set_Ability_to_move(bool ability_to_move)
        {
            _ability_to_move = ability_to_move;
        }
        public string Get_Gender()
        {
            return _gender;
        }
        public int Get_Age()
        {
            return _age;
        }
        public void Set_Age(int age)
        {
            _age = age;
        }
        public int Get_Health_max()
        {
            return _health_max;
        }
        public void Set_Health_max(int health_max)
        {
            _health_max = health_max;
        }
        public int Get_Health_now()
        {
            return _health_now;
        }
        public void Set_Health_now(int health_now)
        {
            _health_now = health_now;
        }
        public int Get_Experience()
        {
            return _experience;
        }
        public void Set_Experience(int experience)
        {
            _experience = experience;
        }
        public enum Condition
        {
            NORMAL,
            WEAKENED,
            SICK,
            POISONED,
            PARALYZED,
            DEAD
        };
        public static void Set_Condition(Condition condition)
        {
            string _condition;
            switch (condition)
            {
                case Condition.NORMAL:
                    _condition = "normal";
                    break;
                case Condition.WEAKENED:
                    _condition = "weakened";
                    break;
                case Condition.SICK:
                    _condition = "sick";
                    break;
                case Condition.POISONED:
                    _condition = "poisoned";
                    break;
                case Condition.PARALYZED:
                    _condition = "paralyzed";
                    break;
                case Condition.DEAD:
                    _condition = "dead";
                    break;
            }
        }
        public enum Race
        {
            PERSON,
            GNOME,
            ELF,
            ORC,
            GOBLIN
        };
        private static void Set_Race(Race race)
        {
            string _race;
            switch (race)
            {
                case Race.PERSON:
                    _race = "person";
                    break;
                case Race.GNOME:
                    _race = "gnome";
                    break;
                case Race.ELF:
                    _race = "elf";
                    break;
                case Race.ORC:
                    _race = "orc";
                    break;
                case Race.GOBLIN:
                    _race = "goblin";
                    break;
            }
        }
        public enum Gender
        {
            MALE,
            FEMALE
        };
        private static void Set_Gender(Gender gender)
        {
            string _gender;
            switch (gender)
            {
                case Gender.MALE:
                    _gender = "male";
                    break;
                case Gender.FEMALE:
                    _gender = "female";
                    break;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //Сharacter c = new Сharacter("Pudge", "normal", "male", true, true, "male", 40, 200, 190, 0);

            }

        }
    }
}
