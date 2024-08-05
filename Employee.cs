public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public decimal Salary { get; set; }

    public Employee(string firstName, string lastName, int birthYear, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
        Salary = salary;
    }
}
