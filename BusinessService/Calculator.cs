using BusinessFacade;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService
{
    public class Calculator : ICalculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}
