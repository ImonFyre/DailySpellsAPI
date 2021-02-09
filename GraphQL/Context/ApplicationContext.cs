using DailySpellsAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;


namespace DailySpellsAPI.GraphQL.Context
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions options)
			: base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid() };
			modelBuilder.ApplyConfiguration(new CharacterContextConfiguration(ids));
			/*modelBuilder.ApplyConfiguration(new CharacterClassContextConfiguration(ids));
			modelBuilder.ApplyConfiguration(new CharacterStatisticsContextConfiguration(ids));*/
			
		}
		public DbSet<Character> Characters { get; set; }
		/*public DbSet<CharacterClass> CharacterClasses { get; set; }
		public DbSet<CharacterStatistics> CharacterStats { get; set; }*/
	}
}