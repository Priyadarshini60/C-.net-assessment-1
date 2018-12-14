using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating instance of class person and passing parameters
            Person p;

            p = new Person("priyanka",23);

            //calling display method on person object
            p.Display();

            //passing parameters to constructor
            p = new Employee("supriya",24,101,"Developer","Angular-developer");

            //calling display method
            p.Display();

            //to hold the screen
            Console.Read();

        }
    }
}
