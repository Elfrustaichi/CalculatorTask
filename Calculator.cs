using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    internal class Calculator:IOperators
    {
        string? _operator = null;
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public string? Operator {
            get { return _operator; }
            set
            {
                
                
                    if (value == "-" || value == "+" || value == "/" || value == "*")
                    {
                        _operator = value;
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("False operation");
                        
                    }

                



            }
        }
        public void Calculate()
        {
            switch (_operator)
            {
                case "+":
                    Sum();
                    break;
                case "-":
                    Substract();
                    break; 
                case "*":
                    Multiply(); 
                    break;
                case "/":
                    Divide();
                    break;
            }
        }

        public void Divide()
        {
            double result = Number1 / Number2;
            Console.WriteLine($"We divided and here is your result:{result}");
        }

        public void Multiply()
        {
            double result = Number1 * Number2;
            Console.WriteLine($"We multiplied and here is your result:{result}");
        }

        public void Sum()
        {
            double result = Number1 + Number2;
            Console.WriteLine($"We do sum and here is your result:{result}");
        }


        public void Substract()
        {
            double result = Number1 - Number2;
            Console.WriteLine($"We substracted and here is your result:{result}");
        }


    }
}
