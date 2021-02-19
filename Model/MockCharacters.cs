using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.Model
{
	public class MockCharacters
	{
		public static CharacterDTO[] characters = {
			new CharacterDTO(1,"Drizzt", "Drow", new CharacterClassDTO[] { new CharacterClassDTO("Barbarian", 3), new CharacterClassDTO("Fighter", 11), new CharacterClassDTO("Ranger", 7) }, new CharacterStatisticsDTO(13, 20, 15, 17, 17, 15)),
			new CharacterDTO(2,"Wulfgar", "Human", new CharacterClassDTO[] { new CharacterClassDTO("Barbarian", 7), new CharacterClassDTO("Fighter", 4) }, new CharacterStatisticsDTO(20, 15, 17, 13, 12, 13)),
			new CharacterDTO(3,"Regis", "Halfing", new CharacterClassDTO[] { new CharacterClassDTO("Rogue", 7) }, new CharacterStatisticsDTO(10, 18, 15, 13, 15, 15)),
			new CharacterDTO(4,"Bruenor", "Dwarf", new CharacterClassDTO[] { new CharacterClassDTO("Fighter", 14) }, new CharacterStatisticsDTO(18, 14, 22, 15, 13, 13)) };
	}
}
