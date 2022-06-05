using System;
using lib.Models;
using lib.Services;

namespace test
{
	public class TestServiceTests
	{
        readonly TestService _testService;

        public TestServiceTests()
        {
            _testService = new();
        }

        [Fact]
		public async Task GetTestAsync_IsHelloWorld()
        {
            Test test = await _testService.GetTestAsync("world");

            Assert.Equal("world", test.Hello);
        }
	}
}

