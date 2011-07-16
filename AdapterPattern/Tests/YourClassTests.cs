using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			var operationPerformerMock = new Mock<IPerformOperation>();

			var sut = new YourClass(operationPerformerMock.Object);

			sut.RunMe();

			operationPerformerMock.Verify(o => o.PerformOperation(It.IsAny<string>()));
		}
	}
}
