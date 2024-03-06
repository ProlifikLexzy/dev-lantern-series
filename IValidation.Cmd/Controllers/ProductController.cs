using DevSeries.Cmd.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSeries.Cmd.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    [HttpPost("new-product")]
    public ActionResult CreateProduct(ProductViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok();
    }
}
