
using DailySpellsAPI.Model;
using System.Collections.Generic;

namespace DailySpellsAPI.GraphQL.Interfaces
{
	public interface ICharacterClassRepository
	{
		IEnumerable<CharacterClass> GetClasses();
	}
}
