using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     Average Operator : Average extension method calculate the average of numeric item in collcection.
    Average method return nummable or non nullable decimal, double or float value.
     */
    internal class AverageOperator
    {
        public void AverageExten()
        {
            IList<int> intList = new List<int>() { 10, 20, 30 };
            var avg = intList.Average();
            Console.WriteLine("Average : {0}", avg);
        }

        public void AverageStudentAge()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName="John",Age=13 },
                new Student(){StudentID = 2,StudentName="Moin",Age=21 },
                new Student(){StudentID = 3,StudentName="Bill",Age=18 },
                new Student(){StudentID = 4,StudentName="Ram",Age=15 }
            };

            var avgAge=studentList.Average(x=>x.Age);
            Console.WriteLine("Average Age of Students : {0}",avgAge);

        }
    }
}
