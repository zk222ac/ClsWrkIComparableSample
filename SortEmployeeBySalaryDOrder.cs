using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ClsWrkIComparableSample
{
    public class SortEmployeeBySalaryDOrder : IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException();
            }

            // one object value  is greater than other object value --> return 1
            if (x.Salary < y.Salary)
            {
                return 1;
            }
            // one object value  is greater than other object value --> return -1

            if (x.Salary > y.Salary)
            {
                return -1;
            }
            // two objects values are equal to each other
            return 0;
        }

       
    }
}
