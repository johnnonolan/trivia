using System;
using NUnit.Framework;

namespace Triviatests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase ()
		{
			Assert.Fail();
		}
	}
}

