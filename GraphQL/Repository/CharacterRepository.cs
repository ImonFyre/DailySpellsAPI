using DailySpellsAPI.DBModel;
using DailySpellsAPI.GraphQL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DailySpellsAPI.GraphQL.Repository
{
	public class CharacterRepository : ICharacterRepository
	{
		private readonly DailySpellsContext _context;

		public CharacterRepository(DailySpellsContext context)
		{
			_context = context;
		}
		public IEnumerable<Character> GetCharacters() => _context.Characters.ToList();
		

		public Character GetCharacter(int charId) { 
			var character = _context.Characters.FirstOrDefault(c => c.Id == charId);
			character.CharacterStats = _context.CharacterStats.FirstOrDefault(c => c.CharacterId == character.Id);
			var classList = _context.CharacterClasses.Where(c => c.CharacterId == character.Id).ToList();
			foreach (CharacterClass cc in classList)
			{
				cc.Class = _context.Classes.FirstOrDefault(c => c.Id == cc.ClassId);
			}
			character.CharacterClasses = classList;
			character.Race = _context.Races.FirstOrDefault(r => r.Id == character.RaceId);
			return character;
		}
	}
}

