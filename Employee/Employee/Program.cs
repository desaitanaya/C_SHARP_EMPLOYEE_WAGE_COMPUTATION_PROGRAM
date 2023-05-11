namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
            Console.WriteLine("--------------------------------------------");

            Random random = new Random();
            int attendance = random.Next(0, 3);

            int salary = 0;

            //Constant variables
            const byte IS_PRESENT_FULL_TIME = 1;
            const byte IS_PRESENT_PART_TIME = 2;
            const byte FULL_DAY_HOUR = 8;
            const byte PART_TIME_HOUR = 4;
            const byte WAGE_PER_HOUR = 20;

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
        }
    }
}