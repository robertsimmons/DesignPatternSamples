namespace AdapterPattern.ExternalLibrary
{
	/* Okay, so obviously you could get here and change this. Pretend
	 * it's an external library that you don't have access to, dammit.
	 * */
	public abstract class UnchangeableBaseClass
	{
		public void PerformOperation(string generalOperationName)
		{
			//Magic stuff happens
		}

		public abstract void RunMe();
	}
}
