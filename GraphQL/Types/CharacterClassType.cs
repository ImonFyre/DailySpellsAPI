using DailySpellsAPI.DBModel;
using GraphQL.Types;

namespace DailySpellsAPI.GraphQL.Types
{
	public class CharacterClassType : ObjectGraphType<CharacterClass>
	{
		public CharacterClassType()
		{
			Field(c => c.Level);
			Field(c => c.Class.ClassName);
		}
	}
}
