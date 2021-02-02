using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpNeeded = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(helpNeeded);
            Console.WriteLine("Were there any postitive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int hrsStudied = Convert.ToInt32(studyHours);

            Console.WriteLine("Your answers: \n" + studentName + "\n" + courseName + "\n" + pgNum + "\n" + needHelp + "\n" + positiveExperiences + "\n" + feedback + "\n" + hrsStudied);

            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly.  Have a great day!");
            Console.Read();




        }
    }
}
