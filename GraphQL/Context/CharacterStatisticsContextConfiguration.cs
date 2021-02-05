
using DailySpellsAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DailySpellsAPI.GraphQL.Context
{
	public class CharacterStatisticsContextConfiguration : AbstractContextConfiguration, IEntityTypeConfiguration<CharacterStatistics>
	{
		public CharacterStatisticsContextConfiguration(System.Guid[] ids) : base(ids) { }

		public void Configure(EntityTypeBuilder<CharacterStatistics> builder)
		{
			throw new System.NotImplementedException();
		}
	}
}
