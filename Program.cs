using System;

class Program
{
    static void Main()
    {
        EmployeeCollection employees = new EmployeeCollection();
        employees.Add(new Employee("John", "Doe", 1980, 50000));
        employees.Add(new Employee("Jane", "Smith", 1990, 60000));
        employees.Add(new Employee("Alice", "Johnson", 1985, 70000));

        Console.WriteLine("Employees in the collection:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}, Birth Year: {employee.BirthYear}, Salary: {employee.Salary:C}");
        }
    }
}
