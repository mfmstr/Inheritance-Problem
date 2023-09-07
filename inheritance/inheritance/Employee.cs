using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace inheritance
{
    public class Employee
    {

        public enum Position
        {
            Manager,
            Developer,
            Tester,
            Other
        }

        public string Name { get; set; }    
        public string LastName {  get; set; }
        public int Age { get; set; }
        public Position position { get; set; }

        public decimal[] WorkingHours = new decimal[7];

        public decimal Salary()
        {
            if (position.Equals(Position.Manager))
            {
                return 40;
            }else if(position.Equals(Position.Developer))
            {
                return 30;
            
            }else if(Position.Other == Position.Tester) {
                return 20;
            }
            else
            {
                return 10;
            }
        }

        public decimal OverTimeMoney()
        {
            decimal hours = 0;

            for(int i = 0; i < WorkingHours.Length; i++)
            {
                if((i == 5 || i == 6) && WorkingHours[i] > 8)
                {
                    hours += (WorkingHours[i] - 8) * 2;
                }
                else
                {
                    if (WorkingHours[i] - 8 > 0) hours += WorkingHours[i] - 8;
                }
            }

            return hours * 5;

        }

        public decimal TotalSalary()
        {

            decimal totalSalary = 0;
            decimal totalHours = 0;

            for(int i = 0; i < WorkingHours.Length; i++)
            {
                if (WorkingHours[i] >= 8) totalSalary += 8 * Salary() + OverTimeMoney();
                totalHours += WorkingHours[i];
            }

            if(totalHours > 50)
            {
                totalSalary *= 1.2m;
            }

            return totalSalary;

        }

        

    }
}
