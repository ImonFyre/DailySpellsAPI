using DailySpellsAPI.GraphQL.Context;
using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DailySpellsAPI.GraphQL
{
	public class CharacterClassRepository : ICharacterClassRepository
	{
		private readonly ApplicationContext _context;
		public IEnumerable<CharacterClass> GetClasses () => _context.CharacterClasses.ToList();
		
	}
}
