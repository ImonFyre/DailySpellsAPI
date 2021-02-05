
using DailySpellsAPI.Model;
using System.Collections.Generic;

namespace DailySpellsAPI.GraphQL.Interfaces
{
	public interface ICharacterRepository
	{
		IEnumerable<Character> GetCharacters();
	}
}
