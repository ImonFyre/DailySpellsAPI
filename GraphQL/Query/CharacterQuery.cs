using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.Types;
using GraphQL;
using GraphQL.Types;

namespace DailySpellsAPI.Query
{
	public class CharacterQuery : ObjectGraphType
	{
		public CharacterQuery(ICharacterRepository repository)
		{
			Field<ListGraphType<CharacterType>>(
				"characters",
				resolve: context => repository.GetCharacters());

			Field<ObjectGraphType<CharacterType>>(
				"character",
				arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
				resolve: context => repository.GetCharacter(context.GetArgument<int>("id"))
			);

		}
	}
}