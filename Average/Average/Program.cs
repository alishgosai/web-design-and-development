using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int total = 0;
            for (int gradecounter =1; gradecounter <= 5; gradecounter = gradecounter + 1)
            {
                Console.Write("Enter the grade:");
                int grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;

            }
            Console.WriteLine("The average of the class is:" + total/5);
            Console.Read();
        }
    }
}
