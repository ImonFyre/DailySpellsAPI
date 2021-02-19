using DailySpellsAPI.DBModel;
using GraphQL.Types;

namespace DailySpellsAPI.GraphQL.Types
{
	public class RaceType : ObjectGraphType<Race>
	{
		public RaceType()
		{
			Field(x => x.Id, type: typeof(IdGraphType));
			Field(x => x.Name).Description("Race Name");
		}
	}
}
