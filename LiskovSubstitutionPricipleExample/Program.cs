using System;

namespace LiskovSubstitutionPricipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new PermanentEmployee();
            Console.WriteLine(employee.GetSalary());
            employee = new ContractEmployee();
            Console.WriteLine(employee.GetSalary());
        }
    }
}
