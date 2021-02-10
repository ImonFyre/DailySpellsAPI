using DailySpellsAPI.Model;
using GraphQL.Types;

namespace DailySpellsAPI.GraphQL.Types
{
	public class CharacterClassType : ObjectGraphType<CharacterClass>
	{
		public CharacterClassType()
		{
			Field(c => c.level);
			Field(c => c.name);
		}
	}
}
