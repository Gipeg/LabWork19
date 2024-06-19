
using Task1;

namespace Task1
{
    internal class OperationMultipy : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    public class operationMultipy : Strategy
    {
        public void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}
