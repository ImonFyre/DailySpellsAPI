using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.Model
{
	public class MockCharacters
	{
		public static Character[] characters = {new Character(1,"Drizzt", "Drow", new CharacterClass[] { new CharacterClass("Barbarian", 3), new CharacterClass("Fighter", 11), new CharacterClass("Ranger", 7) }, new CharacterStatistics(13, 20, 15, 17, 17, 15)),
			new Character(2,"Wulfgar", "Human", new CharacterClass[] { new CharacterClass("Barbarian", 7), new CharacterClass("Fighter", 4) }, new CharacterStatistics(20, 15, 17, 13, 12, 13)),
			new Character(3,"Regis", "Halfing", new CharacterClass[] { new CharacterClass("Rogue", 7) }, new CharacterStatistics(10, 18, 15, 13, 15, 15)),
			new Character(4,"Bruenor", "Dwarf", new CharacterClass[] { new CharacterClass("Fighter", 14) }, new CharacterStatistics(18, 14, 22, 15, 13, 13)) };
	}
}
