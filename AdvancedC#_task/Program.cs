using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__task
{
    internal class Program
    {
        public static List<Employee> Promote(List<Employee> employees, Func<Employee, bool> promotionCriteria)
        {
            List<Employee> promotedEmployees = new List<Employee>();
            foreach (var employee in employees)
            {
                if (promotionCriteria(employee))
                {
                    promotedEmployees.Add(employee);
                }
            }
            return promotedEmployees;
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[5]
       {
            new Student { ID = 3, Name = "Youssef" },
            new Student { ID = 1, Name = "Badry" },
            new Student { ID = 5, Name = "Abdelhamed" },
            new Student { ID = 4, Name = "tony" },
            new Student { ID = 2, Name = "mostafa" }
       };
            Array.Sort(students);

            Console.WriteLine("Sorted students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
            }
            try
            {
                students[5] = new Student { ID = 6, Name = "Sayed" };
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Cannot add new student: " + ex.Message);
            }

            GList<int> intList = new GList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Display();

            GList<string> stringList = new GList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Display();

            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Youssef", Salary = 9000, Gender = "Female", Experience = 3 },
            new Employee { Id = 2, Name = "Badry", Salary = 20000, Gender = "Male", Experience = 6 },
            new Employee { Id = 3, Name = "Abdelhamed", Salary = 9500, Gender = "Male", Experience = 7 },
            new Employee { Id = 4, Name = "tony", Salary = 8000, Gender = "Male", Experience = 2 },
            new Employee { Id = 5, Name = "mostafa", Salary = 15000, Gender = "Female", Experience = 8 }
        };
            List<Employee> promotedBySalary = Promote(employees, emp => emp.Salary < 10000);
            List<Employee> promotedByExperience = Promote(employees, emp => emp.Experience > 5);

            Console.WriteLine("Promoted by Salary:");
            foreach (var emp in promotedBySalary)
            {
                Console.WriteLine(emp.Name);
            }

            Console.WriteLine("\nPromoted by Experience:");
            foreach (var emp in promotedByExperience)
            {
                Console.WriteLine(emp.Name);
            }
            Action<int, int> calculations = null;

            calculations += (a, b) => Console.WriteLine($"Sum: {a + b}");
            calculations += (a, b) => Console.WriteLine($"Sub: {a - b}");
            calculations += (a, b) => Console.WriteLine($"Divide: {a / b}");
            calculations += (a, b) => Console.WriteLine($"Multi: {a * b}");

            Console.WriteLine("\nCalculations:");
            calculations(10, 5);
            Company company = new Company { ID = 1, Name = "TechComp" };
            Supplier supplier = new Supplier { ID = 1, Name = "TechSupply" };

            Product product1 = new Product { ID = 1, Name = "airbuds" };
            Product product2 = new Product { ID = 2, Name = "Smartphone" };

            company.NotifySupplier += supplier.Restock;

            company.AddProduct(product1, 10);
            company.AddProduct(product2, 3);

            company.SellProduct(product1, 6);
            company.SellProduct(product2, 2);
            Console.ReadKey();
        }
    }
}
