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
		public IEnumerable<Character> GetCharacters() => _context.Characters.ToList();
		
	}
}
