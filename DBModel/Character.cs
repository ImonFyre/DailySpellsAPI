using System;
using System.Collections.Generic;

#nullable disable

namespace DailySpellsAPI.DBModel
{
    public partial class Character
    {
        public Character()
        {
            CharacterClasses = new HashSet<CharacterClass>();
            CharacterStats = new CharacterStat();
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int RaceId { get; set; }

        public virtual Race Race { get; set; }
        public virtual ICollection<CharacterClass> CharacterClasses { get; set; }
        public virtual CharacterStat CharacterStats { get; set; }
    }
}
