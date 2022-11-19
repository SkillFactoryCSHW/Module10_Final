using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calc : ICalc
{
    private double summand1;
    private double summand2;

    public Calc(double summand1, double summand2)
    {
        this.summand1 = summand1;
        this.summand2 = summand2;
    }

    public double Sum(double sum1, double sum2)
    {
        return sum1 + sum2;
    }
}
