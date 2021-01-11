using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.Model
{
    public class Character
    {
        public Character() { }

        public Character(string CharacterName)
        {
            name = CharacterName;
        }

        public Character(string CharacterName, string Race) : this(CharacterName)
        {
            race = Race;
        }

        public Character(string CharacterName, string Race, CharacterClass[] characterClasses, CharacterStatistics stats) : this(CharacterName, Race)
        {
            classes = characterClasses;
            characterStats = stats;
        }
        public string name { get; set; }
        public string race { get; set; }
        public CharacterClass[] classes { get; set; }
        public CharacterStatistics characterStats { get; set; }
    }


    public class CharacterClass
    {
        public CharacterClass() { }

        public CharacterClass(string className, int classLevel)
        {
            name = className;
            level = classLevel;
        }
        public string name { get; set; }
        public int level { get; set; }
    }

    public class CharacterStatistics
    {

        public CharacterStatistics() { }

        public CharacterStatistics(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Str = strength;
            Dex = dexterity;
            Con = constitution;
            Int = intelligence;
            Wis = wisdom;
            Cha = charisma;
        }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
    }
}
