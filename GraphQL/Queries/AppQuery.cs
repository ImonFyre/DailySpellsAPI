using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.GraphQL.Types;
using GraphQL;
using GraphQL.Types;

namespace DailySpellsAPI.GraphQL.Queries
{
	public class AppQuery : ObjectGraphType
	{
		public AppQuery(ICharacterRepository repository)
		{
			Field<ListGraphType<CharacterType>>(
				"characters",
				resolve: context => repository.GetCharacters()
			);

			Field<CharacterType>(
				"character",
				arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> {  Name = "id"}),
				resolve: context => repository.GetCharacter(context.GetArgument<int>("id"))
			);
		}
	}
}
