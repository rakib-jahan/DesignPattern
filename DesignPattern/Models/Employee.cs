using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
        public decimal HouseAllowance { get; set; }
        public decimal MedicalAllowance { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }

    public enum EmployeeType
    {
        Contract,
        Permanent
    }
}
