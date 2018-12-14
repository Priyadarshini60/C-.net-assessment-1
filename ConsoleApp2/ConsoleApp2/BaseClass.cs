using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class BaseClass
    {
        //variable declartion
        public int No1;
        public int No2;

        //constructor(default) 
         public BaseClass()
        {
          
        }

        //Constructor with parameters
        public BaseClass(int no1,int no2)
        {
            No1 = no1;
            No2 = no2;
        }
        //properties
        public int no1 { get; set; }
        public int no2 { get; set; }
        //Virtual method
        public virtual int CalculatorAdd(int no1,int no2)
        {

            return no1 + no2;

        }

    }
}
