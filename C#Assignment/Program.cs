using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "P1");
            Product p2 = new Product(2, "P2");


            Supplier s1 = new Supplier(1, "S1");
            Supplier s2 = new Supplier(2, "S2");


            Company company = new Company(1, "MyCompany");


            company.LowStock += s1.Notify;
            company.LowStock += s2.Notify;

            company.AddProduct(p1, 10);
            company.AddProduct(p2, 20);

            company.SellProduct(p1, 6);
            company.SellProduct(p1, 1);
            company.SellProduct(p2, 5);


            Calculator.Calculate calc = Calculator.Sum;
            calc += Calculator.Sub;
            calc += Calculator.Mul;
            calc += Calculator.Divide;

            Console.WriteLine("Calculations:");
            calc(10, 5);


            List<Employee> emps = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ali", Salary = 8000, Gender = "Male", Experience = 6 },
            new Employee { Id = 2, Name = "Mona", Salary = 12000, Gender = "Female", Experience = 3 },
            new Employee { Id = 3, Name = "Fatma", Salary = 20000, Gender = "Female", Experience = 8 },
            new Employee { Id = 4, Name = "Amr", Salary = 9000, Gender = "Male", Experience = 10 }
        };

            List<Employee> promotedEmpsBySalary = EmployeePromoter.Promote(emps, PromotionCriteria.IsSalaryUnder10000);
            Console.WriteLine("Promoted by Salary:");
            foreach (var emp in promotedEmpsBySalary)
            {
                Console.WriteLine($"{emp.Name} with Salary: {emp.Salary}");
            }

            List<Employee> promotedEmpsByExperience = EmployeePromoter.Promote(emps, PromotionCriteria.IsExperienceAbove5);
            Console.WriteLine("Promoted by Experience:");
            foreach (var emp in promotedEmpsByExperience)
            {
                Console.WriteLine($"{emp.Name} with Experience: {emp.Experience}");
            }


            Student[] students = new Student[5];
            students[0] = new Student(3, "Fatma");
            students[1] = new Student(1, "Hema");
            students[2] = new Student(5, "Ahmed");
            students[3] = new Student(2, "Haggag");
            students[4] = new Student(4, "Mahmoud");


            Array.Sort(students);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            try
            {
                students[6] = new Student(6, "Ali");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }


            IStack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadKey();
        }
    }
}
