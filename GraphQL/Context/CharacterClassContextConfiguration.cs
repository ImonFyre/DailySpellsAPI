using DailySpellsAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DailySpellsAPI.GraphQL.Context
{
	public class CharacterClassContextConfiguration : AbstractContextConfiguration, IEntityTypeConfiguration<CharacterClass>
	{
		private Guid[] _ids;
		public CharacterClassContextConfiguration(Guid[] ids) : base(ids) { }

		public void Configure(EntityTypeBuilder<CharacterClass> builder)
		{
            builder
                .HasData(
                new CharacterClass
                {
                    
                },
                new CharacterClass
                {
                    
                },
                new CharacterClass
                {
                    
                }
           ); ;
        }
	}
}
