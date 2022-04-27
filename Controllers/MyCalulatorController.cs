using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lametsy_server.Models;

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



public class Request
{
    public string opp { get; set; }
    public decimal a { get; set; }
    public decimal b { get; set; }
}