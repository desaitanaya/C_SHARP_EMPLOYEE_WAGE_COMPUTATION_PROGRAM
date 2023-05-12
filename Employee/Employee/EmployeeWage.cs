using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeWage
    {
        const byte WAGE_PER_HOUR = 20;
        const byte TOTAL_WORKING_DAYS = 20;
        private static int Attendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 3);
            int status;

            if (attendance == 1)
            {
                Console.WriteLine("Employee is Full Time Present");
                status = 1;
            }
            else if (attendance == 2)
            {
                Console.WriteLine("Employee is Part Time Present");
                status = 2;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                status = 0;
            }
            return status;
        }

        private static int DailyWage()
        {
            int dailyHour = 0;
            int dailyWage = 0;
            int attendanceCheck = Attendance();
            if (attendanceCheck == 1)
            {
                dailyHour = 8;
            }
            else if (attendanceCheck == 2)
            {
                dailyHour = 4;
            }
            else
            {
                dailyHour = 0;
            }
            dailyWage = dailyHour * WAGE_PER_HOUR;
            Console.WriteLine("Salary of Employee is : " + dailyWage);
            return dailyWage;
        }

        public static void MonthlyWage()
        {
            int monthlyWage = 0;
            int dailyWage = DailyWage();
            for (int day = 1; day <= TOTAL_WORKING_DAYS; day++)
            {
                monthlyWage += dailyWage;
            }
            Console.WriteLine("Monthly Wage : ");
        }
    }
}
/*
static void Main(string[] args)
{
    int salary = 0, daily_hour = 0, total_working_hour = 0, monthly_salary = 0 , day =1;

    //Constant variables
    const byte IS_PRESENT_FULL_TIME = 1;
    const byte IS_PRESENT_PART_TIME = 2;
    const byte WAGE_PER_HOUR = 20;
    const byte TOTAL_WORKING_DAYS = 20;
    const byte MAX_WORKING_HOURS = 100;

    /*
     * const byte FULL_DAY_HOUR = 8;
       const byte PART_TIME_HOUR = 4;
    //Checking if the Employee is Present or not
    if (attendance == IS_PRESENT_FULL_TIME)
    {
        //Calculating the salary for Full time Employee
        salary = FULL_DAY_HOUR * WAGE_PER_HOUR;
        Console.WriteLine("Employee is Present for Full time and the Salary is Rs." + salary);
    }
    else if (attendance == IS_PRESENT_PART_TIME)
    {
        //Calculating the salary for Part time Employee
        salary = PART_TIME_HOUR * WAGE_PER_HOUR;
        Console.WriteLine("Employee is Present for Part time and the Salary is Rs." + salary);
    }
    else
    {
        Console.WriteLine("Employee is Absent and the Salary is Rs." + salary);
    }


    //for(int day=1; day<=TOTAL_WORKING_DAYS; day++)
    while(day <= TOTAL_WORKING_DAYS && total_working_hour <= MAX_WORKING_HOURS)
    {
        int attendance = random.Next(0, 3);
        switch (attendance)
        {
            case IS_PRESENT_FULL_TIME:
                daily_hour = 8;
                Console.WriteLine("Employee is Present for Full time");
                break;

            case IS_PRESENT_PART_TIME:
                daily_hour = 4;
                Console.WriteLine("Employee is Present for Part time");
                break;

            default:
                daily_hour = 0;
                Console.WriteLine("Employee is Absent");
                break;
        }

        //Calculating salary of Employee
        salary = daily_hour * WAGE_PER_HOUR;
        Console.WriteLine("Salary of Employee is Rs." + salary);

        //Calculating total working hour of Employee
        total_working_hour = total_working_hour + daily_hour;
        Console.WriteLine("Total working hours : " + total_working_hour);
        Console.WriteLine("--------------------------------------------");

        day++;
    }

    //Calculating Monthly salary of Employee
    monthly_salary = total_working_hour * WAGE_PER_HOUR;
    Console.WriteLine("Monthly salary of Employee is Rs." + monthly_salary);

}
}
}
*/



