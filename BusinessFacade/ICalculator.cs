using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessFacade
{
    public interface ICalculator
    {
        int Add(int value1, int value2);
        int Subtract(int value1, int value2);
    }
}
