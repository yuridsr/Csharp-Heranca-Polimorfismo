using ConsoleApp2.Entities;
using System;
using System.Globalization;


namespace program
{
    class program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listOfEmployee = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #{0} data:", i);
                Console.Write("Outsourced (y/n)? ");
                char yn = char.Parse(Console.ReadLine());

                if (yn == 'n' || yn == 'N')
                {
                    Console.Write("Name: ");
                    string N = Console.ReadLine();
                    Console.Write("Hours: ");
                    int H = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double V = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    listOfEmployee.Add(new Employee(N, H, V));
                }
                else if (yn == 'y' || yn == 'Y')
                {
                    Console.Write("Name: ");
                    string N = Console.ReadLine();
                    Console.Write("Hours: ");
                    int H = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double V = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listOfEmployee.Add(new OutsourcedEmployee(N,H,V,A));
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Payments:");
            foreach (Employee Employee in listOfEmployee) { Console.WriteLine(Employee); }
        }

    }
}