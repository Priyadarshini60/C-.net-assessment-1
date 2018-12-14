using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    //Inherted class from baseclass
    class Calculator:BaseClass
    {
        //Constructor(default)
        public Calculator()
        {

        }

        //Construtor with parameter
        public Calculator(int no1,int no2)
        {
            No1 = no1;
            No2 = no2;

        }

        //Overriden method from the base class
        public override int CalculatorAdd(int no1,int no2)
        {
            
            return no1+no2;

        }


    }



}

