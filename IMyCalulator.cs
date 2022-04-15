using lametsy_server.Controllers;

namespace lametsy_server
{
    public interface IMyCalulator
    {
        public CalculatorResult ResultAdd(decimal a, decimal b);
        public CalculatorResult ResultSub(decimal a, decimal b);
        public CalculatorResult ResultMul(decimal a, decimal b);
        public CalculatorResult ResultDiv(decimal a, decimal b);
    }
}
