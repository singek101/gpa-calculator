using System;

namespace classses_and_methods
{        
         class student
        {
            double cgpa = 0, percentage = 0;

            public void cgpaCalculation()
            {   
            double sum = 0;
            int [] marks = new int[5];
            Console.WriteLine("kindly input student marks:");
            for(int i = 0; i < marks.Length; i++)
            {
                 marks [i] = int.Parse(Console.ReadLine());
            }
            for(int j = 0; j < 5; j++)
            {
                sum = sum + marks[j];
                cgpa =sum / 5;
            }
            Console.WriteLine("CGPA = {0}", cgpa);
            }
            public void cgpaPercentage()
            {
                percentage = cgpa * 9.5;
                Console.WriteLine("PERCENTAGE = {0}", percentage);
            }
        }
    }

