using DevSeries.Cmd.FluentValidation;
using DevSeries.Cmd.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSeries.Cmd.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    public OrderController()
    {
    }

    [HttpPost("Buy")]
    public IActionResult Buy(OrderViewModel viewModel)
    {
        var validator = new OrderFluentValidator();

        var result = validator.Validate(viewModel);

        if (!result.IsValid)
        {
            return BadRequest(result.Errors);
        }

        return Ok();
    }
}
