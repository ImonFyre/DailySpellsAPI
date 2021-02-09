using DailySpellsAPI.Query;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace DailySpellsAPI.GraphQL.GraphQLSchema
{
	public class GraphQLSchema : Schema, ISchema
	{
		public GraphQLSchema(IServiceProvider provider) : base(provider)
		{
			Query = provider.GetRequiredService<CharacterQuery>();
		}
	}
}
