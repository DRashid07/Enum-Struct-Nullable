using Enum_Struct_Nullable.Models;

namespace Enum_Struct_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
            new Employee("Ali", "Aliyev", new DateTime(1995, 5, 10), 2500),
            new Employee("Veli", "Veliyev", new DateTime(1990, 3, 15), 1800),
            new Employee("Aysel", "Mamedova", new DateTime(1998, 7, 20), 3000),
            new Employee("Nurlan", "Quliyev", new DateTime(1988, 2, 1), 2100)
            };
            DateTime date1 = new DateTime(1990, 1, 1);
            DateTime date2 = new DateTime(1999, 12, 31);

            int result = Employee.EmployeeSalary(
            employees,
            date1,
            date2,
            2000m
        );

            Console.WriteLine("2000 - den boyuk olan ishcilerin sayi" + result);


        }
    }
}
