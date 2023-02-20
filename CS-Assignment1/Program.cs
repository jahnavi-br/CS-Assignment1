using System;

namespace Calculator
{
    public delegate void Calculation(int a, int b);

    public class Calculator
    {

        public static void Add(int a, int b)
        {
            int res;
            res = a + b;
            Console.WriteLine("The Sum of {0} and {1} is {2}", a, b, res);
        }
        public static void Sub(int a, int b)
        {
            int res;
            res = a - b;
            Console.WriteLine("The Difference of {0} and {1} is {2}", a, b, res);
        }
        public static void Mul(int a, int b)
        {
            int res;
            res = a * b;
            Console.WriteLine("The Product of {0} and {1} is {2}", a, b, res);
        }
        public static void Div(int a, int b)
        {
            int res;

            if (a > b)
                res = a / b;
            else
                res = b / a;
            Console.WriteLine("The Division of {0} and {1} is {2}", a, b, res);

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;
            Calculation del = new Calculation(Calculator.Add);
            del += Calculator.Sub;
            del += Calculator.Mul;
            del += Calculator.Div;
            del.Invoke(9, 4);
            Console.ReadLine();

        }
    }
}






//string choice;
//Console.WriteLine("Enter First Input:\n");
//a= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Second Input:\n");
//b = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter the operation:\n");
//choice = Console.ReadLine();
//switch (choice)
//{
//    case "+":
//        res = Calculator.Add(a,b);
//        Console.WriteLine("The Sum of {0} and {1} is {2}", a, b, res);
//break;
//    case "-":
//    res = Calculator.Sub(a, b);
//        Console.WriteLine("The Difference of {0} and {1} is {2}", a, b, res);
//        break;
//    case "*":
//    res = Calculator.Mul(a, b);
//        Console.WriteLine("The Product of {0} and {1} is {2}", a, b, res);
//        break;
//    case "/":
//    res = Calculator.Div(a, b);
//        Console.WriteLine("The Division of {0} and {1} is {2}", a, b, res);
//        break;





