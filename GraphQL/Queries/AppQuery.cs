using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.GraphQL.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
		}
	}
}
