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

		public void PerformOperation(Operations operation)
		{
			_baseClass.PerformOperation(operation.ToString());
		}
	}
}
