using System.Net;
using Microsoft.AspNetCore.Mvc;

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
        try
        {
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
        catch(Exception ex)
        {
            return BadRequest(result);
        }
    }
    //[HttpGet("calculator")]
    //public virtual IActionResult GetAddOperation(string opp, double a)
    //{

    //    double result = 0;
    //    switch (opp)
    //    {
    //        case "cos": { result = Math.Cos(a); break; }
    //        default: return BadRequest("input malformed");
    //    }
    //    return Ok(new CalculatorResult
    //    {
    //        OperationResult = result
    //    });
    //}
    //[HttpGet("calculatorCos")]
    //public IActionResult GetAddOperation(string opp, double a)
    //{
    //    double result = 0;

    //    switch (opp)
    //    {
    //        case "cos": { result = Math.Cos(a); break; }
    //        default: return BadRequest("input malformed");
    //    }
    //    return Ok(new CalculatorResult
    //    {
    //        OperationResult = result
    //    });
    //}
}

public class CalculatorResult
{
    public decimal? OperationResult { get; internal set; }
    public string? Error { get; set; }
}

public class Request
{
    public string opp { get; set; }
    public decimal a { get; set; }
    public decimal b { get; set; }
}