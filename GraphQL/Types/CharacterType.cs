using DailySpellsAPI.Model;
using GraphQL.Types;

namespace DailySpellsAPI.Types
{
	public class CharacterType : ObjectGraphType<Character>
	{
		public CharacterType()
		{
			Name = "Character";
			Field(_ => _.Id);
			Field(_ => _.Name).Description("Character Name");
			Field(_ => _.Race).Description("Character Race");
			Field(_ => _.Classes, nullable: true, type: typeof(ListGraphType<CharacterClassType>)).Description("Character Classes");
			Field(_ => _.CharacterStats, nullable:false, type: typeof(ObjectGraphType<CharacterStatisticsType>)).Description("Character stats");
		}
	}
}
