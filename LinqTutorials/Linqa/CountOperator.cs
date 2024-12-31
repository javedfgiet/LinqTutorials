using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
  Count : The Count operator return the number of elements in the collection 
    OR 
  The number of elements that have satisfied the given condition.
     */
    internal class CountOperator
    {
        public void GetTotalElementCount()
        {
            IList<int> elements = new List<int>() { 10, 21, 30, 45, 50 };
            var totalCount = elements.Count();

            Console.WriteLine("Total Element : {0}", totalCount);

            var evenElements = elements.Count(x => x % 2 == 0);
            Console.WriteLine("Total Even Element : {0}", evenElements);
        }

        public void GetAvgStudentAge()
        {

            IList<Student> students = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName="John",Age=13},
                new Student(){StudentID=2,StudentName="Moin",Age=21},
                new Student(){StudentID=3,StudentName="Bill",Age=18},
                new Student(){StudentID=4,StudentName="Ram",Age=20},
                new Student(){StudentID=5,StudentName="Ron",Age=15}
            };

            var totalStudents = students.Count(x=>x.Age>=18);

            Console.WriteLine("Student Above Age 18 : {0}", totalStudents);
        }
    }
}
