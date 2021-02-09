using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailySpellsAPI.Model
{
	public class CharacterClass
    {
        public CharacterClass() { }

        public CharacterClass(string className, int classLevel)
        {
            name = className;
            level = classLevel;
        }
        public Guid Id { get; set; }
        [ForeignKey("CharacterId")]
        public Guid CharacterId { get; set; }
        public string name { get; set; }
        public int level { get; set; }
    }
}
