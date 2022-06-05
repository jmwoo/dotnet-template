using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public object Get() 
    {
        return Redirect("/test");
    }

    [HttpGet("test")]
    public object GetTest()
    {
        return new 
        {
            hello = "world"
        };
    }
}
