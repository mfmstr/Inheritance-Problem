using System;

namespace inheritance
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Company nikora = new Company();
            nikora.IsNative = true;
            nikora.Transaction(20000); // Output 3600

            Company nike = new Company();
            nike.IsNative = false;
            nike.Transaction(20000); // Output 1000

            Employee John = new Employee();
            John.Name = "John";
            John.LastName = "Watson";
            John.position = 0; // Manager
            John.Age = 35;
            John.WorkingHours = new decimal[] { 8m, 8m, 8m, 8m, 8m, 8m, 9m };

            Console.WriteLine($"{John.Name} {John.LastName}, your total salary is {John.TotalSalary()} GEL");





        }
    }
}
