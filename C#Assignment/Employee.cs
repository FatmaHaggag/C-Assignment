using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }

    }

    static class PromotionCriteria
    {
        public static bool IsSalaryUnder10000(Employee emp) => emp.Salary < 10000;

        public static bool IsExperienceAbove5(Employee emp) => emp.Experience > 5;
    }

    delegate bool IsPromoted(Employee emp);

    static class EmployeePromoter
    {
        public static List<Employee> Promote(List<Employee> emps, IsPromoted p)
        {
            return emps.Where(emp => p(emp)).ToList();
        }
    }
}


