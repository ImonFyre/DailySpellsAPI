using DailySpellsAPI.Model;
using GraphQL.Types;

namespace DailySpellsAPI.Types
{
	public class CharacterType : ObjectGraphType<Character>
	{
		public CharacterType()
		{
			Name = "Character";
			Field(_ => _.name).Description("Character Name");
			Field(_ => _.race).Description("Character Race");
			Field(_ => _.classes).Description("Character Class(es)");
			Field(_ => _.characterStats).Description("Character stats");
		}
	}
}
