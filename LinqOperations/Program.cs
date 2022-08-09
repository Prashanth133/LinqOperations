using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "John" ,Age = 44},
                new Employee(){Id = 2, Name = "Alex", Age = 22},
                new Employee(){Id = 3,Name = "Shivam",Age = 28},
                new Employee(){Id = 4, Name = "Akash", Age = 30},
                new Employee(){Id = 5, Name = "Lisa", Age = 33},
                new Employee(){Id = 6, Name = "Maria", Age = 25}
            };

            var query = (from emp in employees 
                        select emp).ToList();

            foreach (var item in query)
            {
                Console.WriteLine($"Id:{item.Id}, Name:{item.Name}, Age:{item.Age}");
            }

            var names = employees.Select(emp => emp.Name).ToList();
            foreach (var item in names)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();

            //where 
            Console.WriteLine("=====where clause======");
            var youngEmp = from emp in employees
                        where emp.Age <= 30
                        select emp;
            foreach(var item in youngEmp)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }

            Console.WriteLine();
            //order by
            Console.WriteLine("=====Order By======");
            var agesinDesc = employees.OrderByDescending(emp => emp.Age).ToList();

            foreach(var item in agesinDesc)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }
            Console.WriteLine();
            //contains

            Console.WriteLine("=====Contains======");
            List<Student> students = new List<Student>
          {
              new Student{Id = 1, Name = "Kane"},
              new Student{Id = 2, Name = "John"},
          };
            var isExist = students.Contains(new Student {Id = 2, Name = "John" });
            Console.WriteLine(isExist);



        }
    }
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
