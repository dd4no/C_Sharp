using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main()
        {
            // Create employee list with names and ID
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {ID = 1, Name = "Joe Jackson" },
                new Employee() {ID = 2, Name = "Mick Jagger" },
                new Employee() {ID = 3, Name = "Joe Strummer" },
                new Employee() {ID = 4, Name = "Jim Morrison" },
                new Employee() {ID = 5, Name = "Polly Jean Harvey" },
                new Employee() {ID = 6, Name = "Roger Daltry" },
                new Employee() {ID = 7, Name = "Neil Young" },
                new Employee() {ID = 8, Name = "Hope Sandoval" },
                new Employee() {ID = 9, Name = "Margot Timmins" },
                new Employee() {ID = 10, Name = "Thom Yorke" }
            };

            // Create list of employees with name of "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Name.Contains("Joe"))
                {
                    joes.Add(employee);
                }
            }

            // Use Lambda Expression to create list of employees with name of "Joe"
            List<Employee> moreJoe = employees.Where(x => x.Name.Contains("Joe")).ToList();

            // Use Lambda Expression to create list of employees with ID greater than 5
            List<Employee> employeeIDs = employees.Where(y => y.ID > 5).ToList();                 
        }
    }
}
