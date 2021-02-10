using DailySpellsAPI.Model;
using GraphQL.Types;

namespace DailySpellsAPI.GraphQL.Types
{
	public class CharacterType : ObjectGraphType<Character>
	{
		public CharacterType()
		{
			Field(x => x.Id, type: typeof(IdGraphType));
			Field(x => x.Name).Description("Character Name");
			Field(x => x.Race).Description("Character Race");
			Field(x => x.CharacterStats, type: typeof(CharacterStatsType));
			Field<ListGraphType<CharacterClassType>>("classes");
		}
	}
}
