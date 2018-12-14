using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of two numbers is::");

            //variable declaration
            int Answer;
            //creating object of base class
            BaseClass b;
            
            b = new Calculator();
            //Calling CalculatorAdd method on base class object and storing the result in Answer variable
            Answer=b.CalculatorAdd(15,20);
            //Printing answer on console
            Console.WriteLine(Answer);
            
            //to hold the screen(console)
            Console.Read();



        }
    }
}
