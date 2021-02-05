using DailySpellsAPI.GraphQL.Context;
using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DailySpellsAPI.GraphQL
{
	public class CharacterStatisticsRepository : ICharacterStatsRepository
	{
		private readonly ApplicationContext _context;
		public IEnumerable<CharacterStatistics> GetStats() => _context.CharacterStats.ToList();
		
	}
}
