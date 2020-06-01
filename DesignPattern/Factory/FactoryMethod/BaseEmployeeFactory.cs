using DesignPattern.Managers;
using DesignPattern.Models;

namespace DesignPattern.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        public Employee ApplySalary()
        {
            IEmployeeManager manager = Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
            return _emp;
        }

        public abstract IEmployeeManager Create();
    }
}