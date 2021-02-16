using System;
using System.Collections.Generic;

namespace ClsWrkIComparableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // you can sorting bedefault in INt and string 
            List<int> listInt = new List<int>() { 2, 23, 56, 45, 78, 1, 34 };

            Console.WriteLine("ellemets before sort");
            DisplayInt(listInt);
            Console.WriteLine("ellemets after sort");
            listInt.Sort();
            DisplayInt(listInt);

            // 


            List<Employee> employees = new List<Employee>
            {
                new Employee("Tony" , 10000), // obj1 Tony
                new Employee("catalina" , 15000), // obj2 - catalina
                new Employee("Paulina", 12000),
                new Employee("Andrie", 14000),
                new Employee("Radu", 16000),
                new Employee("Razu", 18000),
                new Employee("Gabor", 19000),
                new Employee("Edem", 15000)
            };
            Console.WriteLine("Object ellemets before sort...............");
            Display(employees); 
            // when you call this sort method in object data type
            // You should have implement IComparable interface
            employees.Sort();
            Console.WriteLine("Object ellemets after Asycending sort...........");
            Display(employees);

            Console.WriteLine("Sort Employee By Name........................");
            employees.Sort(new SortEmployeeByName());
            Display(employees);
            Console.WriteLine("Sort Employee Salary By desending order..........");

            employees.Sort(new SortEmployeeBySalaryDOrder());

            Display(employees);


            Console.ReadKey();
            // 1 min : 
        }

        public static void Display(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
        public static void DisplayInt(List<int> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

    }
}          
        

