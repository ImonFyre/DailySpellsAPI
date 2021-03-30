using DailySpellsAPI.GraphQL.Queries;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace DailySpellsAPI.GraphQL.GraphQLSchema
{
	public class AppSchema : Schema
	{
		public AppSchema(IServiceProvider provider) : base(provider)
		{
			Query = provider.GetRequiredService<AppQuery>();
		}
	}
}
