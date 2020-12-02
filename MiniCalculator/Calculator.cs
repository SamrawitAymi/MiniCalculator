using System;

namespace MiniCalculator
{
    public class Calculator
    {
        private static double FirstNumber { get; set; }
        private static double SecondNumber { get; set; }
        
       
        public Calculator() { }

        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;     
        }
        public static double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static double Multiply(double firstNumber, double secondNumber)
        {
            return (firstNumber * secondNumber);
        }

        public static double DivisionResult { get; set; }
        public static void Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
                {
                    DivisionResult = firstNumber / secondNumber;
                }
            else
                {
                throw new ArgumentException("Cannot divide by zero");

                }
        }
        public static double PowOfFirstNumber1(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
            
        }
        public static double PowOfSecondNumber2(double firstNumber, double secondNumber)
        {
            return Math.Pow(secondNumber, firstNumber);

        }

        public static void Main(string[] args)
        {
            Calculate();

        }

        private static void Calculate()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the first integer");
                    FirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the second integer: ");
                    SecondNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Please enter only integer number!");
                }



                double addResult = Add(FirstNumber, SecondNumber);
                Console.WriteLine($"The sum of {FirstNumber} and  {SecondNumber} =  {addResult}");

                double subResult = Subtract(FirstNumber, SecondNumber);
                Console.WriteLine($"The subtraction of {FirstNumber} and  {SecondNumber} = {subResult}");


                double multiResult = Multiply(FirstNumber, SecondNumber);
                Console.WriteLine($"The multiple of {FirstNumber} and  {SecondNumber} = {multiResult}");
                Console.WriteLine($"The power of {FirstNumber}^ {SecondNumber} = {PowOfFirstNumber1(FirstNumber, SecondNumber)}");
                Console.WriteLine($"The power of {SecondNumber} ^ {FirstNumber} = {PowOfSecondNumber2(FirstNumber, SecondNumber)}");
                
                try
                {
                    Divide(FirstNumber, SecondNumber);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
               
                if (DivisionResult != 0)
                {
                    Console.WriteLine($"The division of {FirstNumber} /  {SecondNumber} = {DivisionResult}");
                }


                Console.WriteLine("Do you want to exit ?! Y:N?");
                char Terminat = Console.ReadKey().KeyChar;
                if (Terminat == 'Y' || Terminat == 'y')
                {
                    break;
                }
            }
        }
    }
}

