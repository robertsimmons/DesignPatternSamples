using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.YourSoftware
{
	public interface IPerformOperation
	{
		void PerformOperation(string message);
	}
}
