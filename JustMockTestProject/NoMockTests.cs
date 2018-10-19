using NUnit.Framework;

namespace JustMockTestProject
{
	[TestFixture]
	public class NoMockTests
	{
		[Test]
		public void TestFooPropertyNoMock()
		{
			var sut = new Foo();
			sut.FooProperty = true;

			Assert.AreEqual(true, sut.FooProperty);
		}

		[Test]
		public void TestExecuteFooMethodNoMock()
		{
			int value = 0;

			var sut = new Foo();
			sut.ExecuteFoo();
			value++;

			Assert.AreEqual(1, value);
		}
	}
}
