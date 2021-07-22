using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Grade
{
    public class Grade
    {

            public double input  ; //properties

            public Grade (double input)//constructor
            {
                this.input = input;//Dependency
            }
        public string grade() //medthod
            {
            var result = "";

            if (input >= 80 && input<=100)
            {
                result = "Your grade is A";
            }
            else if (input >= 70 && input <= 80)
            {
                result = "Your grade is B";
            }
            else if (input >= 60 && input <= 70)
            {
                result = "Your grade is C";
            }
            else if (input >= 50 && input <=60)
            {
                result = "Your grade is D";
            }
            else if (input >= 0 && input <= 50)
            {
                result = "Your grade is F";
            }
            return result;
        }
         
            public double Display()//medthod

        {
                return input;
            }
        }
    }
