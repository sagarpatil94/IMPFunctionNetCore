using DinkToPdf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdf.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> EmployeesData()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Mike",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Mike1",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Mike2",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Mike3",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 5,
                    Name = "Mike4",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 6,
                    Name = "Mike5",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 7,
                    Name = "Mike6",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 8,
                    Name = "Mike7",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 9,
                    Name = "Mike8",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 10,
                    Name = "Mike9",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },
                new Employee()
                {
                    Id = 11,
                    Name = "Mike10",
                    Add = "Chicago",
                    Age = 10,
                    PhoneNumber = "08444444444444"
                },

            };
            return employees;
        }
    }
}
