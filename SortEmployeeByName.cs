using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ClsWrkIComparableSample
{
    public class SortEmployeeByName : IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if((x == null) || (y == null))
            {
                throw new ArgumentNullException();
            }

            // Employee emp1 = (Employee)x;
            // Employee emp2 = (Employee)y;

            return String.Compare(x.Name, y.Name);
        }
    }
}
