
using CalculationAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculationAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{

    [HttpPost("calculate")]
    public IActionResult Calculate([FromBody] CalcRequest request)
    {
   
        if (request == null)
        {
            return BadRequest("Invalid request data.");
        }


        double result = request.A * request.B;

     
        return Ok(new { Result = result });
    }
}