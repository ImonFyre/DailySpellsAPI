using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace DailySpellsAPI.GraphQL.Repository
{
	public class CharacterRepository : ICharacterRepository
	{
		public IEnumerable<Character> GetCharacters() => MockCharacters.characters;

		public Character GetCharacter(int charId) => MockCharacters.characters.FirstOrDefault(c => c.Id == charId);
	}
}
