using lib.Models;

namespace lib.Services;

public class  TestService 
{
	public async Task<Test> GetTestAsync(string message) 
	{
		await Task.Yield();

		return new()
		{
			Hello = message
		};
	}
}

