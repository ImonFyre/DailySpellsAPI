using DailySpellsAPI.GraphQL.Queries;
using GraphQL.Types;
using GraphQL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
