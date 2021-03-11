using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("John", "Doe", 50000M);
            Employee employee2 = new Employee("Sue", "Jones", 150000M);

            Console.WriteLine("Employee1 Name is: {0} {1}", employee1.FirstName, employee1.LastName);
            Console.WriteLine("Employee1 Salary is: ${0}", employee1.Salary);
            employee1.Salary = employee1.Salary * 12;
            Console.WriteLine("Employee1 yearly salary is: ${0}", employee1.Salary);

            Console.WriteLine("Employee2 Name is: {0} {1}", employee2.FirstName, employee2.LastName);
            Console.WriteLine("Employee2 Salary is: ${0}", employee2.Salary);
            employee2.Salary = employee2.Salary * 12;
            Console.WriteLine("Employee2 yearly salary is: ${0}", employee2.Salary);


            Console.WriteLine();
            Console.WriteLine("After 10% raise");

            employee1.Salary = employee1.Salary * 1.1M;
            employee2.Salary = employee2.Salary * 1.1M;

            Console.WriteLine("Employee1 new Salary is: ${0}", employee1.Salary);
            Console.WriteLine("Employee2 new Salary is: ${0}", employee2.Salary);


            Console.ReadKey();
        }
    }
}
