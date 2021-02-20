using DailySpellsAPI.Interfaces;
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
				resolve: context => {
					var character = repository.GetCharacter(context.GetArgument<int>("id"));
					return character;
					}
			);
		}
	}
}
