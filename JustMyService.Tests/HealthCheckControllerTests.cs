using JustMyService.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace JustMyService.Tests;
public class HealthCheckControllerTests
{
    [Fact]
    public void Get_ReturnsOkResult()
    {
        var controller = new HealthCheckController();
        var result = controller.Get();

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(200, okResult.StatusCode);
    }
}