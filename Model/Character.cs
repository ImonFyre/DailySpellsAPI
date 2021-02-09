using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.Model
{
    public class Character
    {
        public Character() { }

        public Character(int id, string characterName)
        {
            Id = id;
            Name = characterName;
        }

        public Character(int id, string characterName, string race) : this(id, characterName)
        {
            this.Race = race;
        }

        public Character(int id, string characterName, string race, CharacterClass[] characterClasses, CharacterStatistics stats) : this(id, characterName, race)
        {
            Classes = characterClasses;
            CharacterStats = stats;
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public CharacterClass[] Classes { get; set; }
        public CharacterStatistics CharacterStats { get; set; }
    }
}
