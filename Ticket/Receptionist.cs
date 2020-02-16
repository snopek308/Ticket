using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Receptionist
    {
        //ticketPrint
        int numApplicants = 0;
        String finalResult = "";

        public void ticketPrint()
        {
            Console.WriteLine("Enter the number of applicants: ");
            numApplicants = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numApplicants; i++)
            {
                Process temp = new Process();
                temp.Retrieve();
                temp.processData();
                finalResult = finalResult + "\n" + temp.returnResult();
            }
            Console.WriteLine(finalResult);
        }

    }
}
