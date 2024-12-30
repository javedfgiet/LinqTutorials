using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
    
    Aggregate : Perform a custom aggregation operation on the values in the collection.
    The Aggragate method performs an accumulate operation.

     */
    internal class AggregateOps
    {
        public void AggragtaeMethod()
        {
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            var commaSeparatedString = strList.Aggregate((s1, s2) => s1 + " , " + s2);
            Console.WriteLine(commaSeparatedString);
        }

        /*
         Aggregate Method with Seed Value: The Second overload method of Aggregate requires first 
        parameter for seed value to accumulate
         */
        public void AggregatedStudent()
        {
            IList<Student> students = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName="John",Age=13},
                new Student(){StudentID=2,StudentName="Moin",Age=21},
                new Student(){StudentID=3,StudentName="Bill",Age=18},
                new Student(){StudentID=4,StudentName="Ram",Age=20},
                new Student(){StudentID=5,StudentName="Ron",Age=15}
            };

            string commaSepStudent = students.Aggregate("Student Names: ",
                (str, s) => str += s.StudentName + ",");
            Console.WriteLine(commaSepStudent);
        }

        /*
        Aggregate Method with Result Selector:
        This Overload version require the third parameter of Func delegate expression for 
        result selector 
         */

        public void AggregatedStudentWithResultSelector()
        {
            IList<Student> students = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName="John",Age=13},
                new Student(){StudentID=2,StudentName="Moin",Age=21},
                new Student(){StudentID=3,StudentName="Bill",Age=18},
                new Student(){StudentID=4,StudentName="Ram",Age=20},
                new Student(){StudentID=5,StudentName="Ron",Age=15}
            };

            string commaSeparatedString=students.Aggregate(String.Empty,
                                            (s1,s2)=>s1 += s2.StudentName+ ",",
                                            str=>str.Substring(0,str.Length -1)
                                            );

            Console.WriteLine(commaSeparatedString);


        }
    }
}
