using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using DailySpellsAPI.Model;

namespace DailySpellsAPI.GraphQL.Context
{
	public class CharacterContextConfiguration : AbstractContextConfiguration, IEntityTypeConfiguration<Character>
	{

		public CharacterContextConfiguration(System.Guid[] ids) : base(ids) {
			
		}

		public void Configure(EntityTypeBuilder<Character> builder)
		{
			throw new NotImplementedException();
		}
	}
}
