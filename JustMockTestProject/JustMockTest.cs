using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Telerik.JustMock;
using NUnit.Framework;

namespace JustMockTestProject
{
	[TestFixture]
	public class JustMockTest
	{
		[Test]
		public void TestFooProperty()
		{
			var sut = Mock.Create<Foo>();
			Mock.Arrange(() => sut.FooProperty).Returns(true);

			Assert.AreEqual(true, sut.FooProperty);
		}

		[Test]
		public void TestExecuteFooMethod()
		{
			int value = 0;

			var sut = Mock.Create<Foo>();
			Mock.Arrange(() => sut.ExecuteFoo()).DoInstead(() => value++);

			sut.ExecuteFoo();

			Assert.AreEqual(1, value);
		}
	}
}
