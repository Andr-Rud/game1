using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCharacter
{
    class Character
    {
        private static int _next_index = 0;
        private int _index;
        private string _name;
        private string _condition;
        private string _raсe;
        private bool _ability_to_speak;
        private bool _ability_to_move;
        private string _gender;
        private uint _age;
        private uint _health_max;
        private uint _health_now;
        private uint _experience;
        private Dictionary<string, int> _inventory_non_renewable = new Dictionary<string, int>(4);
        private Dictionary<string, bool> _inventory_renewable = new Dictionary<string, bool>(2);
        public Character(string name, Condition condition, Race race, bool ability_to_speak, bool ability_to_move, Gender gender, uint age, uint health_max, uint health_now, uint experience)
        {

            ++_next_index;
            _index = _next_index;
            _name = name;
            Set_Condition(condition);
            Set_Race(race);
            Set_Ability_to_speak(ability_to_speak);
            Set_Ability_to_move(ability_to_move);
            Set_Gender(gender);
            Set_Age(age);
            Set_Health_max(health_max);
            Set_Health_now(health_now);
            Set_Experience(experience);
            _inventory_non_renewable.Add("living_water_bottle", 0);
            _inventory_non_renewable.Add("dead_water_bottle", 0);
            _inventory_non_renewable.Add("frog_legs_decort", 0);
            _inventory_non_renewable.Add("basilisk_eye", 0);
            _inventory_renewable.Add("poisonous_saliva", false);
            _inventory_renewable.Add("staff_lightning", false);
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
        public uint Get_Age()
        {
            return _age;
        }
        public void Set_Age(uint age)
        {
            _age = age;
        }
        public uint Get_Health_max()
        {
            return _health_max;
        }
        public void Set_Health_max(uint health_max)
        {
            if (health_max < this.Get_Health_now())
            {
                _health_now = health_max;
            }
            _health_max = health_max;
            this.Check_Condition();
        }
        public uint Get_Health_now()
        {
            return _health_now;
        }
        public void Set_Health_now(uint health_now)
        {
            if (health_now > this.Get_Health_max())
            {
                _health_now = _health_max;
            }
            _health_now = health_now;
            this.Check_Condition();
        }
        public uint Get_Experience()
        {
            return _experience;
        }
        public void Set_Experience(uint experience)
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
        public void Set_Condition(Condition condition)
        {
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
        private void Set_Race(Race race)
        {
            //  string _race;
            switch (race)
            {
                case Race.PERSON:
                    _raсe = "person";
                    break;
                case Race.GNOME:
                    _raсe = "gnome";
                    break;
                case Race.ELF:
                    _raсe = "elf";
                    break;
                case Race.ORC:
                    _raсe = "orc";
                    break;
                case Race.GOBLIN:
                    _raсe = "goblin";
                    break;
            }
        }
        public enum Gender
        {
            MALE,
            FEMALE
        };
        private void Set_Gender(Gender gender)
        {
            // string _gender;
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
        public virtual new string ToString()
        {
           // Console.ForegroundColor = ConsoleColor.Green;
            return "***********************" +
                '\n' + " id: " + _index + '\n' + " name: " + _name + '\n' + " condition: " + _condition + '\n' +
                " race: " + _raсe + '\n' + " ability to speak: " + _ability_to_speak + '\n' +
                " ability to move: " + _ability_to_move + '\n' + " gender: " + _gender + '\n' + " age: " + _age + '\n' + " health_max: " +
                _health_max + '\n' + " health now: " + _health_now + '\n' + " experience: " + _experience + '\n';
        }
        //.................. get set finish
        private void Check_Condition()
        {
            if ((Get_Condition() == "normal") && (Get_Health_now() / Get_Health_max() < 0.1))
            {
                this.Set_Condition(Condition.SICK);
            }
            if ((Get_Condition() == "sick") && (Get_Health_now() / Get_Health_max() >= 0.1))
            {
                this.Set_Condition(Condition.NORMAL);
            }
            if (Get_Health_now() == 0)
            {
                this.Set_Condition(Condition.DEAD);
            }
        }
        public string Comparison_by_experience(Character a, Character b)
        {
            if (a.Get_Experience() > b.Get_Experience())
            {
                return "exp " + a.Get_Name() + " with id " + a.Get_Index() + " > exp " + b.Get_Name() + " with id " + b.Get_Index();
            }
            if (a.Get_Experience() < b.Get_Experience())
            {
                return "exp " + a.Get_Name() + " with id " + a.Get_Index() + " < exp " + b.Get_Name() + " with id " + b.Get_Index();
            }
            else
            {
                return "exp " + a.Get_Name() + " with id " + a.Get_Index() + " == exp " + b.Get_Name() + " with id " + b.Get_Index();
            }
        }
        public void Pick_Up_An_Artefact(Artefact a)
        {
            if (a.GetType().Name == "Living_Water_Bottle")
            {
                ++_inventory_non_renewable["living_water_bottle"];
            }
            if (a.GetType().Name == "Dead_Water_Bottle")
            {
                ++_inventory_non_renewable["dead_water_bottle"];
            }
            if (a.GetType().Name == "Frog_Legs_Decort")
            {
                ++_inventory_non_renewable["frog_legs_decort"];
            }
            if (a.GetType().Name == "Basilisk_Eye")
            {
                ++_inventory_non_renewable["basilisk_eye"];
            }
            if (a.GetType().Name == "Poisonous_Saliva")
            {
                _inventory_renewable["poisonous_saliva"] = true;
            }
            if (a.GetType().Name == "Staff_Lightning")
            {
                _inventory_renewable["staff_lightning"] = true;
            }
        }
        public void Throw_Away_The_Artefact(Artefact a)
        {
            if (a.GetType().Name == "Living_Water_Bottle" && _inventory_non_renewable["living_water_bottle"] > 0)
            {
                --_inventory_non_renewable["living_water_bottle"];
            }
            if (a.GetType().Name == "Dead_Water_Bottle" && _inventory_non_renewable["dead_water_bottle"] > 0)
            {
                --_inventory_non_renewable["dead_water_bottle"];
            }
            if (a.GetType().Name == "Frog_Legs_Decort" && _inventory_non_renewable["frog_legs_decort"] > 0)
            {
                --_inventory_non_renewable["frog_legs_decort"];
            }
            if (a.GetType().Name == "Basilisk_Eye" && _inventory_non_renewable["basilisk_eye"] > 0)
            {
                --_inventory_non_renewable["basilisk_eye"];
            }
            if (a.GetType().Name == "Poisonous_Saliva")
            {
                _inventory_renewable["poisonous_saliva"] = false;
            }
            if (a.GetType().Name == "Staff_Lightning")
            {
                _inventory_renewable["staff_lightning"] = false;
            }
        }
        public void Transfer_An_Artefact_To_Another_Character(Artefact a, Character b)
        {
            this.Throw_Away_The_Artefact(a);
            b.Pick_Up_An_Artefact(a);
        }
        public void Use_Artefact(Artefact a, Character b, uint power)
        {
            if (a.GetType().Name == "Living_Water_Bottle" && _inventory_non_renewable["living_water_bottle"] > 0)
            {
                --_inventory_non_renewable["living_water_bottle"];
            }
            if (a.GetType().Name == "Dead_Water_Bottle" && _inventory_non_renewable["dead_water_bottle"] > 0)
            {
                --_inventory_non_renewable["dead_water_bottle"];
            }
            if (a.GetType().Name == "Frog_Legs_Decort" && _inventory_non_renewable["frog_legs_decort"] > 0)
            {
                --_inventory_non_renewable["frog_legs_decort"];
            }
            if (a.GetType().Name == "Basilisk_Eye" && _inventory_non_renewable["basilisk_eye"] > 0)
            {
                --_inventory_non_renewable["basilisk_eye"];
            }
            Character_With_Magic temp = new Character_With_Magic();
            a.To_perform_a_magical_effect(b, temp, power);
        }
    }
}