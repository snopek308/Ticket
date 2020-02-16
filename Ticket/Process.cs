using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Process
    {
        String fName = "";
        String lName = "";
        String gender = "";
        String genderUpper = "";
        int age = 0;
        String result = "";

        //retrieve data
        public void Retrieve()
        {
            Console.WriteLine("Please enter your first name: ");
            fName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        //process data
        public void processData()
        {
            if (age < 18)
            {
                result = fName + " X";
            }
            else
            {
                Console.WriteLine("Please enter your last name: ");
                lName = Console.ReadLine();
                Console.WriteLine("Please enter your gender: F or M");
                gender = Console.ReadLine();
                genderUpper = gender.ToUpper();

                if(genderUpper == "F")
                {
                    result = "Ms " + lName + " is allowed into the program";
                }
                else
                {
                    result = "Mr " + lName + " is allowed into the program";
                }
                
            }
        }
        
        public String returnResult()
        {
            return result;
        }

        //returnResult
    }
}
