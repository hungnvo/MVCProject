using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmployeeManagementContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            var types = new EmployeeType[]
            {
                new EmployeeType { EmployeeTypeID = 1, EmployeeDiscription = "Employee" },
                new EmployeeType { EmployeeTypeID = 2, EmployeeDiscription = "Manager" },
            };
            foreach (EmployeeType s in types)
            {
                context.EmployeeType.Add(s);
            }
            context.SaveChanges();

            Employee temp = new Employee { First = "Adam", Last = "Lele", Year = 3, Month = 5, EmployeeTypeID = 1 };
            context.Employee.Add(temp);
            context.SaveChanges();

        }
    }
}
