using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Classes
{
    internal class Employee
    {
        public int EmployeeId;
        public string firstName;
        public string lastName;
        public double salary;

        public Employee(int employeeId, string firstName, string lastName, float salary)
        {
            this.EmployeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("EmployeeId: " + EmployeeId);
            Console.WriteLine("Fistname: " +  firstName);
            Console.WriteLine("Lastname: " +  lastName);
            Console.WriteLine("Salary: " +  salary);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Deevanshu", "Sabharwal",50000);
            Employee e2 = new Employee(2, "Kanika", "Sabharwal", 50000);

            e1.display();
            e2.display();

            Console.ReadLine(); 
        }
    }
}
