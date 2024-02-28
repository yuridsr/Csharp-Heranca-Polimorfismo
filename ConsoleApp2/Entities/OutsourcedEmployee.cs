using System.Xml.Schema;

namespace ConsoleApp2.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additionalCharge)
            :base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override  double payment()
        {       
            return base.payment() + (AdditionalCharge * 1.1);
        }

    }
}
