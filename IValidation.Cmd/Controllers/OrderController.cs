using DevSeries.Cmd.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSeries.Cmd.Controllers;
public class OrderController : ControllerBase
{
    public OrderController()
    {
    }

    public async Task<IActionResult> Buy(OrderViewModel viewModel)
    {
        return Ok();
    }
}
