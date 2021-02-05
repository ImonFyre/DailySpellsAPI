using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.GraphQL.Context
{
	
	public class AbstractContextConfiguration
	{
		private Guid[] _ids;
		public AbstractContextConfiguration(Guid[] ids)
		{
			_ids = ids;
		}
	}
}
