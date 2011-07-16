using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.ExternalLibrary;

namespace AdapterPattern.YourSoftware
{
	public class YourClass : UnchangeableBaseClass
	{
		private readonly IPerformOperation _operationPerformer;

		public YourClass()
		{
			_operationPerformer = new UnchangeableAdapter(this);
		}

		public YourClass(IPerformOperation operationPerformer)
		{
			_operationPerformer = operationPerformer;
		}

		public override void RunMe()
		{
			_operationPerformer.PerformOperation("howdy");
		}
	}
}
