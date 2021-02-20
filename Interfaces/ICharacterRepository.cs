using DailySpellsAPI.DBModel;
using System.Collections.Generic;

namespace DailySpellsAPI.Interfaces
{
	public interface ICharacterRepository
	{
		IEnumerable<Character> GetCharacters();

		Character GetCharacter(int charId);
	}
}
