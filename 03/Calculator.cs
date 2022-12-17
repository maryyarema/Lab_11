using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Calculator
    {
        private ICalculate Strategy;
        public Calculator()
        {
            Strategy = new Adding();
        }
        public void ChangeStrategy(string operation)
        {
            switch (operation)
            {
                case "+":
                    Strategy = new Adding();
                    break;
                case "-":
                    Strategy = new Substract();
                    break;
                case "*":
                    Strategy = new Multiply();
                    break;
                case "/":
                    Strategy = new Divide();
                    break;
            }
        }
        public int Calculation(int value1, int value2)
        {
            return Strategy.Calculate(value1, value2);
        }
    }
}
