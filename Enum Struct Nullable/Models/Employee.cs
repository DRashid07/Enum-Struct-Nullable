namespace Enum_Struct_Nullable.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, string surname, DateTime birthday, decimal salary)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Salary = salary;
        }
        public static int EmployeeSalary(Employee[] employees, DateTime startDate, DateTime endDate, decimal minSalary)
        {
            if (startDate > endDate)
            {
                var temp = startDate; startDate = endDate; endDate = temp;
            }
            int count = 0;
            foreach (var employee in employees)
            {
                bool isBirthdayInRange = employee.Birthday >= startDate && employee.Birthday <= endDate;
                bool isGreaterThanSalary = employee.Salary > minSalary;
                if (isBirthdayInRange && isGreaterThanSalary)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
