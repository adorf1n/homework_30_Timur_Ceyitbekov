using System.Collections.Generic;

public class SalaryComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return x.Salary.CompareTo(y.Salary);
    }
}
