using DesignPattern.Models;

namespace DesignPattern.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory factory = null;

            switch (emp.EmployeeType)
            {
                case EmployeeType.Contract:
                    factory = new ContractEmployeeFactory(emp);
                    break;
                case EmployeeType.Permanent:
                    factory = new PermanentEmployeeFactory(emp);
                    break;
                default:
                    break;
            }

            return factory;
        }
    }
}