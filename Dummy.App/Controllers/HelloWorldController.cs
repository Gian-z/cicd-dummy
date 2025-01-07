using Microsoft.AspNetCore.Mvc;

namespace dummy.Controllers;

public class HelloWorldController : Controller
{
    [HttpGet]
    public string GetHelloWorld()
    {
        return "Hello World!";
    }
}