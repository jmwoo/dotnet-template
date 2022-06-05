using lib.Models;
using lib.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    readonly ILogger<TestController> _logger;
    readonly ITestService _testService;

    public TestController(ILogger<TestController> logger, ITestService testService)
    {
        _logger = logger;
        _testService = testService;
    }

    [HttpGet("")]
    public object Get() 
    {
        return Redirect("/test");
    }

    [HttpGet("test")]
    public async Task<Test> GetTest([FromQuery] string? msg)
    {
        Test test = await _testService.GetTestAsync(msg);

        _logger.LogInformation(test.Message);

        return test;
    }
}
