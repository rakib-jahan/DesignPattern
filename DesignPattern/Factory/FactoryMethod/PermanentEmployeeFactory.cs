using DesignPattern.Managers;
using DesignPattern.Models;

namespace DesignPattern.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}