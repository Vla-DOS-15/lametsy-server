using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lametsy_server.Controllers;

[ApiController]
[Route("api")]
public class MyCalulatorController : ControllerBase
{
    private readonly IMyCalulator myCalulator;

    public MyCalulatorController(IMyCalulator myCalulator)
    {
        this.myCalulator = myCalulator;
    }

    [HttpGet("calculator")]
    public IActionResult GetAddOperation(string opp, decimal a, decimal b)
    {
        CalculatorResult result = new CalculatorResult();

        switch (opp)
        {
            case "add": { result = myCalulator.ResultAdd(a, b); break; }
            case "sub": { result = myCalulator.ResultSub(a, b); break; }
            case "mul": { result = myCalulator.ResultMul(a, b); break; }
            case "div": { result = myCalulator.ResultDiv(a, b); break; }
            default: return BadRequest("input malformed");
        }
       
        return Ok(result);
    }
}
