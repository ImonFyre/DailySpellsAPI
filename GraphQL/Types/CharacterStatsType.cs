
using DailySpellsAPI.DBModel;
using GraphQL.Types;

namespace DailySpellsAPI.GraphQL.Types
{
	public class CharacterStatsType : ObjectGraphType<CharacterStat>
	{
		public CharacterStatsType()
		{
			Field(stat => stat.Str);
			Field(stat => stat.Dex);
			Field(stat => stat.Con);
			Field(stat => stat.Int);
			Field(stat => stat.Wis);
			Field(stat => stat.Cha);
		}
	}
}
