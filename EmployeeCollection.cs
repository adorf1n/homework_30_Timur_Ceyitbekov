using System;
using System.Collections;
using System.Collections.Generic;

public class EmployeeCollection : IEnumerable<Employee>
{
    private List<Employee> employees = new List<Employee>();

    public void Add(Employee employee)
    {
        employees.Add(employee);
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        return new EmployeeEnumerator(employees);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class EmployeeEnumerator : IEnumerator<Employee>
    {
        private List<Employee> _employees;
        private int _position = -1;

        public EmployeeEnumerator(List<Employee> employees)
        {
            _employees = employees;
        }

        public Employee Current
        {
            get
            {
                if (_position < 0 || _position >= _employees.Count)
                    throw new InvalidOperationException();
                return _employees[_position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return (_position < _employees.Count);
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
        }
    }
}
