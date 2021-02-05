
using DailySpellsAPI.Model;
using System.Collections.Generic;

namespace DailySpellsAPI.GraphQL.Interfaces
{
	public interface ICharacterStatsRepository
	{
		public IEnumerable<CharacterStatistics> GetStats();
	}
}
