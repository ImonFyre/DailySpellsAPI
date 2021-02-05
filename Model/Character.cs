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
}
