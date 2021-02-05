using DailySpellsAPI.Model;
using GraphQL.Types;

namespace DailySpellsAPI.Types
{
	public class CharacterStatisticsType : ObjectGraphType<CharacterStatistics>
	{
		public CharacterStatisticsType()
		{
			Name = "Character";
			Field(_ => _.Str).Description("Strength score");
			Field(_ => _.Dex).Description("Dexterity score");
			Field(_ => _.Con).Description("Constitution score");
			Field(_ => _.Int).Description("Intelligence score");
			Field(_ => _.Wis).Description("Wisdom score");
			Field(_ => _.Cha).Description("Charisma score");
		}
	}
}
