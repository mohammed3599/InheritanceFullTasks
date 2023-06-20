using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFullTask
{
    internal abstract class Employee
    {
        string Name;
        public double Salary;
        string Department;

        public Employee(string Name, double Salary, string Department) 
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Department = Department;
        }
        public abstract void CalculatePay();
    }
    internal class Manager : Employee
    { 
        double noOfEmp;

        public Manager(string Name, double Salary, string Department, double noOfEmp) : base(Name, Salary, Department)
        {
            this.noOfEmp = noOfEmp;
        } 
        public override void CalculatePay()
        {
            Console.WriteLine(Salary);
        }
    }
    internal class Secretary : Employee
    {
        public int HourPerWeek;

        public Secretary(string Name, double Salary, string Department, int HourPerWeek) : base(Name, Salary, Department)
        {
            this.HourPerWeek = HourPerWeek;
        }
        public override void CalculatePay()
        {
            Console.WriteLine(Salary);
        }
    }
}
