using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Calculator
{
    class Program
    {
        static void Print(int sira, dynamic[] menu)
        {
            for(int i = 0; i < 5; i++)
            {
                if (i == sira)
                {
       Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(menu[i]); Console.ForegroundColor = ConsoleColor.White;
                }
                else { Console.WriteLine(menu[i]); }
            }
        }

        static int EnterOperator(ref int sira, dynamic[] menu)
        {
            dynamic sechim;
            while (true)
            {
                
                sechim = Console.ReadKey();   
                if (sechim.Key == ConsoleKey.DownArrow)
                {
                    if (sira < 4) sira++;
                    Console.Clear();
                    Print(sira, menu);
                }
                if (sechim.Key == ConsoleKey.UpArrow)
                {
                    if (sira > 0) sira--;
                    Console.Clear();
                    Print(sira, menu);
                }
                if (sechim.Key == ConsoleKey.Enter)
                {
                    return sira;
                }
            }
            
        }
        static double Add(double numb1, double numb2)
        {
            return numb1 + numb2;
        }

        static double Subtract(double numb1, double numb2)
        {
            return numb1 - numb2;
        }

        static double Multiply(double numb1, double numb2)
        {
            return numb1 * numb2;
        }

        static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Error: Cannot divide by zero");
            }
            return num1 / num2;
        }
        static double Power(double num1, double num2)
        {
            double a = 1; 
            for(int i = 0; i < num2; i++)
            {
                a *= num1;
            }
            return a;
        }

        static void Main(string[] args)
        {
            string[] girish = { "<<< Add >>>", "<<< Subtract >>>", "<<< Vurulma >>>", "<<< Devide >>>", "<<< Super >>>" };
            double num1, num2, result;
            char op;
            int sechim = 0;
            Console.Write("Enter the first numb : ");
            num1 = double.Parse(Console.ReadLine());

            Print(sechim, girish);
            EnterOperator(ref sechim, girish);

            Console.Write("Enter the second numb : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (sechim)
            {
                case 0:
                    result = Add(num1, num2);
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                    break;

                case 1:
                    result = Subtract(num1, num2);
                    Console.WriteLine($"{num1} - {num2} = {result}" );
                    break;

                case 2:
                    result = Multiply(num1, num2);
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                    break;

                case 3:
                    try
                    {
                        result = Divide(num1, num2);
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    result = Power(num1, num2);
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;

                default:
                    Console.WriteLine("Error: ONSUZDA DEFOULTA GIRISH IZNI VERILMEYIB ))");
                    break;
            }

            Console.ReadKey();
        }
    }
}