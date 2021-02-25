using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                var student = new Student() { FirstName = "Dave", LastName = "Defourneaux" };
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Grade Grade { get; set; }
    }

    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeLetter { get; set; }
        public string Course { get; set; }
        public virtual List<Student> Students { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
