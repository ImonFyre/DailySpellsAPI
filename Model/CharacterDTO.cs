using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.Model
{
    public class CharacterDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public CharacterClassDTO[] Classes { get; set; }
        public CharacterStatisticsDTO CharacterStats { get; set; }


        public CharacterDTO() { }

        public CharacterDTO(int id, string characterName)
        {
            Id = id;
            Name = characterName;
        }

        public CharacterDTO(int id, string characterName, string race) : this(id, characterName)
        {
            this.Race = race;
        }

        public CharacterDTO(int id, string characterName, string race, CharacterClassDTO[] characterClasses, CharacterStatisticsDTO stats) : this(id, characterName, race)
        {
            Classes = characterClasses;
            CharacterStats = stats;
        }
       
    }
}
