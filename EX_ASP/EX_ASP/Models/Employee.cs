using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace EX_ASP.Models
{
    public class Employee
    {
        [RegularExpression(@"EM[0-9]*")]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}
