using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Inherited class from class Person
    class Employee:Person
    {
        //declaring data members
        public int EmpID;
        public String Department;
        public String Designation;

        //construtor(default)
        public Employee()
        {
            
        }

        //parameterized constructor
        public Employee(String name,int age,int empid,string department,string designation)
        {
            Name = name;
            Age = age;
            EmpID = empid;
            Department = department;
            Designation = designation;
        }

        //Properties
        public int empid
        {
            get;set;
        }

        public string department
        {
            get; set;
        }

        public string designation
        {
            get; set;
        }

        //Overriden method
        public override void Display()
        {
            System.Console.WriteLine("Employee details are:"+"\n" + "Name::"+""+Name+"\n"+"Age::"+""+Age+"\n"+"EmployeeID::"+""+EmpID+"\n"+"Department::"+""+Department+"\n"+"Designation::"+""+Designation);
        }
    }

}
