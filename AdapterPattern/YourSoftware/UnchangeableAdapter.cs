using AdapterPattern.ExternalLibrary;

namespace AdapterPattern.YourSoftware
{
	// Our Adapter implements the interface we want to work against.
	// Also, we name our class with "Adapter". When using patterns, this helps
	// the team to work with a common terminology, and to explain complex ideas simply
	public class UnchangeableAdapter : IPerformOperation
	{
		private readonly UnchangeableBaseClass _baseClass;

		// Since we're translating one interface to another, we're going to have to actually
		// have a reference to the class that implements the original interface
		public UnchangeableAdapter(UnchangeableBaseClass baseClass)
		{
			_baseClass = baseClass;
		}

		// This is our implementation of our new interface. It simply
		// acts as a pass-through to the original version, along with translating our parameters
		public void PerformOperation(Operations operation)
		{
			_baseClass.PerformOperation(operation.ToString());
		}
	}
}
