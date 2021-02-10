using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.GraphQL.Repository
{
	public class CharacterRepository : ICharacterRepository
	{
		public IEnumerable<Character> GetCharacters() => MockCharacters.characters;
	}
}
