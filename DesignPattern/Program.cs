using DesignPattern.Factory.FactoryMethod;
using DesignPattern.Models;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "Rakib";
            //employee.EmployeeType = EmployeeType.Permanent;

            //BaseEmployeeFactory factory = new EmployeeManagerFactory().CreateFactory(employee);
            //factory.ApplySalary();

            var employee = new EmployeeView(new EmployeeData());
            Console.WriteLine(employee.GetEmployeeFullName());
        }
    }

    public interface IEmployeeData
    {
        string GetEmployeeFullName();
    }

    public class EmployeeData : IEmployeeData
    {
        public string GetEmployeeFullName()
        {
            return "Rakib Jahan Khan";
        }
    }

    public class EmployeeView
    {
        private IEmployeeData _employeeData;

        public EmployeeView(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        public string GetEmployeeFullName()
        {
            return _employeeData.GetEmployeeFullName();
        }
    }
}
