using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    public class Students
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    internal class SelectQueryClass
    {
        IList<Student> studentList = new List<Student>()
        {
            new Student(){StudentID = 1,StudentName="John",Age=13 },
            new Student(){StudentID = 2,StudentName="Moin",Age=21 },
            new Student(){StudentID = 3,StudentName="Bill",Age=18 },
            new Student(){StudentID = 4,StudentName="Ram",Age=15 }
        };

        public void GetStudents()
        {
            // Query Syntax....
            //var selectResult = from s in studentList
            //                   select new { Name = "Mr." + s.StudentName, Age = s.Age };

            // Method Syntax....
            var selectResult=studentList.Select(s=>new {Name="Mr." +s.StudentName,Age=s.Age});


            foreach (var student in selectResult)
            {
                Console.WriteLine("Student Name : {0}, Age: {1}", student.Name, student.Age);
            }
        }


    }
}
