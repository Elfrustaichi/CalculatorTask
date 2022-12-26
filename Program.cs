



using CalculatorTask;
using System.Reflection.Metadata.Ecma335;

Calculator Calculator = new Calculator();




while (true)
{
    Console.Write("Enter the first Number:");
    try
    {
        Calculator.Number1 = int.Parse(Console.ReadLine());
        break;
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("Pls enter correct Number.");
        
        continue;
    }
}

do
{
    Console.Write("Enter the operator:");
    Calculator.Operator = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(Calculator.Operator));
    

    



while (true)
{
    Console.Write("Enter the second Number:");
    try
    {
        Calculator.Number2 = int.Parse(Console.ReadLine());
        break;
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("Pls enter correct number.");
        continue;
    }

    
}

Calculator.Calculate();