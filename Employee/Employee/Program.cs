namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
            Console.WriteLine("--------------------------------------------");

            Random random = new Random();
            int attendance = random.Next(0, 2);

            int salary = 0;

            //Constant variables
            const byte FULL_DAY_HOUR = 8;
            const byte WAGE_PER_HOUR = 20;

            //Checking if the Employee is Present or not
            if (attendance == 1)
            {
                salary = FULL_DAY_HOUR * WAGE_PER_HOUR;
                Console.WriteLine("Employee is Present for Full time and the Salary is Rs." + salary);
            }
            else
            {
                Console.WriteLine("Employee is Absent and the Salary is Rs." + salary);
            }
        }
    }
}