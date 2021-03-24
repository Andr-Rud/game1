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
            _index++;// так?
                     // Set_Index(index);// надо удалить скорее всего
            Set_Name(name);
            ForCondition(condition);
            //Set_Condition(condition);
            ForRace(race);
            //Set_Raсe(race);
            Set_Ability_to_speak(ability_to_speak);
            Set_Ability_to_move(ability_to_move);
            ForGender(gender);
            //Set_Gender(gender);
            Set_Age(age);
            Set_Health_max(health_max);
            Set_Health_now(health_now);
            Set_Experience(experience);
        }
        public int Get_Index()
        {
            return _index;
        }
        public void Set_Index(int index)
        {
            _index = index;
        }
        public string Get_Name()
        {
            return _name;
        }
        public void Set_Name(string name)
        {
            _name = name;
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
        public void Set_Raсe(string raсe)
        {
            _raсe = raсe;
            //static void ForRace(Race race, string _race)
            //{

            //    switch (race)
            //    {
            //        case Race.PERSON:
            //            _race = "person";
            //            break;
            //        case Race.GNOME:
            //            _race = "gnome";
            //            break;
            //        case Race.ELF:
            //            _race = "elf";
            //            break;
            //        case Race.ORC:
            //            _race = "orc";
            //            break;
            //        case Race.GOBLIN:
            //            _race = "goblin";
            //            break;
            //    }
            //}
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
        public void Set_Gender(string gender)
        {
            _gender = gender;
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

        public int Index
        {
            get
            {
                return _index;
            }
            set => _index = value;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set => _name = value;
        }
        public string Conditions
        {
            get
            {
                return _condition;
            }
            set => _condition = value;
        }
        private string Rases
        {
            get
            {
                return _raсe;
            }
            set => _raсe = value;
        }
        public bool Ability_to_speak
        {
            get
            {
                return _ability_to_speak;
            }
            set => _ability_to_speak = value;
        }
        public bool Ability_to_move
        {
            get
            {
                return _ability_to_move;
            }
            set => _ability_to_move = value;
        }
        private string Genders
        {
            get
            {
                return _gender;
            }
            set => _gender = value;
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set => _age = value;
        }
        public int Health_max
        {
            get
            {
                return _health_max;
            }
            set => _health_max = value;
        }
        public int Health_now
        {
            get
            {
                return _health_now;
            }
            set => _health_now = value;
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set => _experience = value;
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
        static void ForCondition(Condition condition)
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
        //    public string GetCondition(Condition condition)
        //{
        //    Сharacter k;

        //    if (k.Now_Condition = Сharacter.Condition.NORMAL)
        //        return "normal";
        //    if (condition == WEAKENED)
        //        return ("weakened");
        //    if (condition == SICK)
        //        return "sick";
        //    if (condition == POISONED)
        //        return "poisoned";
        //    if (condition == PARALYZED)
        //        return "paralyzed";
        //    if (condition == DEAD)
        //        return "dead";
        //}
        public Condition Now_Condition
        {
            get;
            set;
        }
        public enum Race
        {
            PERSON,
            GNOME,
            ELF,
            ORC,
            GOBLIN
        };
        static void ForRace(Race race)
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
        public Race Now_Race
        {
            get;
            set;
        }
        public enum Gender
        {
            MALE,
            FEMALE
        };
        static void ForGender(Gender gender)
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
        public Gender Now_Gender
        {
            get;
            set;
        }

    }
}
