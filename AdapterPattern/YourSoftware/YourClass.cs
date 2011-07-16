using AdapterPattern.ExternalLibrary;

namespace AdapterPattern.YourSoftware
{
	public class YourClass : UnchangeableBaseClass
	{
		private readonly IPerformOperation _operationPerformer;

		// Our parameter-less constructor, as needed by the other system.
		public YourClass()
		{
			// Here, we get our concrete adapter. This example is trivial,
			// so nothing more is required, but if you're interested in better
			// software design, I'd recommend checking out the Factory pattern 
			// and Inversion of Control libraries, like Ninject or StructureMap!
			_operationPerformer = new UnchangeableAdapter(this);
		}

		// We expose this constructor to allow for testing!
		public YourClass(IPerformOperation operationPerformer)
		{
			_operationPerformer = operationPerformer;
		}

		public override void RunMe()
		{
			// Let's simple call the function on our interface!
			_operationPerformer.PerformOperation(Operations.KeepingItReal);
		}
	}
}
