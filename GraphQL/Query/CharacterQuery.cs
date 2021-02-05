using DailySpellsAPI.GraphQL.Interfaces;
using DailySpellsAPI.Service;
using DailySpellsAPI.Types;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.Query
{
	public class AppQuery : ObjectGraphType
	{
		public AppQuery(ICharacterRepository repository)
		{
			Field<ListGraphType<CharacterType>>(
				"characters",
				resolve: context => repository.GetCharacters());
		}
	}
}
