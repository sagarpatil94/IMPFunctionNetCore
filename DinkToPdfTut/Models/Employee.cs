using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdfTut.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
    }
    public class EmployeeData
    {
        public static List<Employee> Employees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Address = "Chicago",
                    Gender = true,
                    Name = "Fiona",
                    Phone ="84123456789"
                },
                new Employee()
                {
                    Id = 1,
                    Address = "Chicago",
                    Gender = true,
                    Name = "Fiona",
                    Phone ="84123456789"
                },
                new Employee()
                {
                    Id = 1,
                    Address = "Chicago",
                    Gender = true,
                    Name = "Fiona",
                    Phone ="84123456789"
                },
                new Employee()
                {
                    Id = 1,
                    Address = "Chicago",
                    Gender = true,
                    Name = "Fiona",
                    Phone ="84123456789"
                },
                new Employee()
                {
                    Id = 1,
                    Address = "Chicago",
                    Gender = true,
                    Name = "Fiona",
                    Phone ="84123456789"
                }
            };
            return employees;
        }
    }
}
