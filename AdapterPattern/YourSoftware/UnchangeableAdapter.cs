using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.ExternalLibrary;

namespace AdapterPattern.YourSoftware
{
	public class UnchangeableAdapter : IPerformOperation
	{
		private readonly UnchangeableBaseClass _baseClass;

		public UnchangeableAdapter(UnchangeableBaseClass baseClass)
		{
			_baseClass = baseClass;
		}

		public void PerformOperation(string message)
		{
			_baseClass.PerformOperation(message);
		}
	}
}
