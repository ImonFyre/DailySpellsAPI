using DailySpellsAPI.GraphQL.Context;
using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DailySpellsAPI.GraphQL
{
	public class CharacterRepository : ICharacterRepository
	{
		private readonly ApplicationContext _context;
		
		public CharacterRepository(ApplicationContext context)
		{
			_context = context;
		}

		public IEnumerable<Character> GetCharacters()
		{
			return MockCharacters.characters;
		}

		public Character GetCharacter(int id)
		{
			return MockCharacters.characters[id];
		}
	}
}
