double summand1;
double summand2;

try
{
    Console.WriteLine("Enter summand one");
    summand1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter summand two");
    summand2 = Convert.ToDouble(Console.ReadLine());

    Calc calc = new Calc(summand1, summand2);
    Console.WriteLine(calc.Sum(summand1, summand2));
}
catch (Exception ex)
{
    if (ex is InputException) throw new InputException("Please enter correct value");
}


