using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailySpellsAPI.Model
{
	public class CharacterClassDTO
    {
        public CharacterClassDTO() { }

        public CharacterClassDTO(string className, int classLevel)
        {
            name = className;
            level = classLevel;
        }
        
        public string name { get; set; }
        public int level { get; set; }
    }
}
