using System.Collections.Generic;

public class BirthYearComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return x.BirthYear.CompareTo(y.BirthYear);
    }
}
