using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_EmployeeDetailsUsingListAnotherType
{
    public  class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }



        public void AddEmployees()
        {
            Console.WriteLine("Enter Employee ID");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Date Of Join");
            DateOfJoining = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            Salary = double.Parse(Console.ReadLine());
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID  : " + EmployeeId);
            Console.WriteLine("Employee Name  : " + EmployeeName);
            Console.WriteLine("Employee Date Of Join  : " + DateOfJoining);
            Console.WriteLine("Employee Salary  : " + Salary);
        }
    }
}

