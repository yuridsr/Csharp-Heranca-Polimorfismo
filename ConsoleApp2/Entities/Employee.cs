using System.Globalization;

namespace ConsoleApp2.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double payment()
        {
            return ValuePerHour * Hours;
        }
        
        public override string ToString()
        {
            return Name + " - $ " + payment().ToString("F2", CultureInfo.InvariantCulture) ;
        }

    }

}
