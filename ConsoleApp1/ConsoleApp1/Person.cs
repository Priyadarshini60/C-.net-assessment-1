using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        //declaring data members
        public String Name;
        public int Age;

        //Default constructor
        public Person()
        {
            
        }

        //parameterized constructor
        public Person(String name,int age)
        {
            Name = name;
            Age = age;
        }

        //Properties
        public String name { get; set; }
        public int age { get; set; }


        //Declaring a virtual method to display items
        public virtual void Display()
        {
            System.Console.WriteLine("Person details:"+"\n"+"Name::"+""+Name+"\n"+"Age::"+""+Age);
        }

    }
}
