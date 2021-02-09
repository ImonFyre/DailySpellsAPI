using DailySpellsAPI.Model;
using GraphQL.Types;

namespace DailySpellsAPI.Types
{
	public class CharacterClassType : ObjectGraphType<CharacterClass>
	{
		public CharacterClassType()
		{
			Name = "Character";
			Field(_ => _.Id);
			Field(_ => _.CharacterId);
			Field(_ => _.name).Description("Character Class Name");
			Field(_ => _.level).Description("Character Class Level");
		}
	}
}
