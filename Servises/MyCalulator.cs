using lametsy_server.Controllers;

namespace lametsy_server;

public class MyCalulator : IMyCalulator
{
    public CalculatorResult ResultAdd(decimal a, decimal b)
    {
        try
        {
            return new CalculatorResult 
            { 
                OperationResult = a + b 
            };
        }
        catch (Exception ex)
        {
            return new CalculatorResult
            {
                Error = ex.Message
            };
        }
    }
    public CalculatorResult ResultDiv(decimal a, decimal b)
    {
        var result = new CalculatorResult
        {
            Error = "No Error"
        };
        try
        {
            result.OperationResult = a / b;
        }
        catch (Exception ex)
        {
            result.Error = ex.Message;

        }
        return result;
    }
    public CalculatorResult ResultSub(decimal a, decimal b)
    {
        try
        {
            return new CalculatorResult
            {
                OperationResult = a - b
            };
        }
        catch (Exception ex)
        {
            return new CalculatorResult
            {
                Error = ex.Message
            };
        }
    }
    public CalculatorResult ResultMul(decimal a, decimal b)
    {
        try
        {
            return new CalculatorResult
            {
                OperationResult = a * b
            };
        }
        catch (Exception ex)
        {
            return new CalculatorResult
            {
                Error = ex.Message
            };
        }
    }
}