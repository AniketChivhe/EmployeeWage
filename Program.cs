using System;

namespace EmployeeWage
{
    class Program
    {
           static void Main(string[] args)
        {
            //checking employee present or not
            int Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine(empCheck);
            if (empCheck == Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }


            //for uc2 print
            DailyWage dailyWage = new DailyWage();
            dailyWage.abc();
            
            //for uc3 print
            PartTime partTime = new PartTime();
            partTime.xyz();

            //for uc4 print
            UC4 uC4 = new UC4();
            uC4.lmn();
            
            //for uc 5 print
            WagesForMonth wagesForMonth = new WagesForMonth(); 
               wagesForMonth.aaa();

            //for uc 6 print
            UC6 uC6 = new UC6();
            uC6.bbb();

            Console.ReadKey();        
        }
    }
}
