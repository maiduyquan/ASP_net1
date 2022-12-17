using Microsoft.EntityFrameworkCore;
using EX_ASP.Models;
using System;
using System.Linq;
using EX_ASP.Data;

namespace EX_ASP.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new EX_ASPContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<EX_ASPContext>>()))
			{
				// Look for any movies.
				if (context.Employee.Any())
				{
					return;   // DB has been seeded
				}
				context.Employee.AddRange(
					new Employee
					{
						EmployeeId = "EM001",
						EmployeeName = "Jonh Carter",
						Department = "HR",
						Salary = 3000
					},
					new Employee
					{
						EmployeeId = "EM002",
						EmployeeName = "Michael Bean",
						Department = "SC",
						Salary = 1300
					},
					new Employee
					{
						EmployeeId = "EM003",
						EmployeeName = "Jimmy Floy",
						Department = "MD",
						Salary = 2000
					},
					new Employee
					{
						EmployeeId = "EM004",
						EmployeeName = "Mary Brown",
						Department = "MD",
						Salary = 2000
					}
				);
				context.SaveChanges();
			}
		}
    }
}
