using System;

namespace Azure_TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            int result = calculator.Add(5, 6);

            if (result != 11)
                throw new InvalidOperationException();
        }
    }
}
