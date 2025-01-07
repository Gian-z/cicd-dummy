using dummy.Controllers;
using NUnit.Framework;

namespace Dummy.Tests;

[TestFixture]
public class DummyTests
{
    private HelloWorldController _controller = null!;
    
    [SetUp]
    public void SetUp()
    {
        _controller = new HelloWorldController();
    }

    [TearDown]
    public void TearDown()
    {
        _controller.Dispose();
    }
    
    [TestCase]
    public void Test_HelloWorld()
    {
        var response = _controller.GetHelloWorld();
        Assert.That(response, Is.EqualTo("Hello World!"));
    }
}