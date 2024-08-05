using System.Collections.Generic;

public class LastNameComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return string.Compare(x.LastName, y.LastName);
    }
}
