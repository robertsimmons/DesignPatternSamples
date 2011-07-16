using AdapterPattern.YourSoftware;
using Moq;
using NUnit.Framework;

namespace AdapterPattern.Tests
{
	[TestFixture]
	public class YourClassTests
	{
		[Test]
		public void WhenRunning_ItShouldPerformOperation()
		{
			// Moq simply asks for what interface we wished our object used
			var operationPerformerMock = new Mock<IPerformOperation>();

			// Now, due to the parameterless constructor constraint, we'll have to do something
			// interesting in our implementation, but we need this for testing. There's multiple
			// ways we could deal with this problem, but the one I use involves multiple constructors
			var sut = new YourClass(operationPerformerMock.Object);

			// Oh, and "sut" means "System Under Test" :)
			sut.RunMe();

			// This Moq command verifies that our class (YourClass) calls the PerformOperation method on the interface
			// properly. We don't care about the parameter at this point.
			operationPerformerMock.Verify(o => o.PerformOperation(It.IsAny<Operations>()));
		}
	}
}
