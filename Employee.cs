using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ClsWrkIComparableSample
{
    // How we implement Icomparable interface in the class 
   public  class Employee : IComparable<Employee>
    {
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public int Salary { get; set; }      



        // [1,23,null,56,67] --> from value would be null

        public int CompareTo([AllowNull] Employee other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            // one object value  is greater than other object value --> return 1
            if (Salary > other.Salary)
            {
                return 1;
            }
            // one object value  is greater than other object value --> return -1

            if (Salary < other.Salary)
            {
                return -1;
            }
            // two objects values are equal to each other
            return 0;
        }

        public override string ToString()
        {
            return $"This Employees {Name} has a Salary {Salary}"; 
        }

    }
}
