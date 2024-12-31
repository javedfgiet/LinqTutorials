using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    internal class MaxOperator
    {
        public void GetMax()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

            var largest = intList.Max();

            Console.WriteLine("Largest Element : {0}", largest);

            var largestEvenElement = intList.Max(x =>
            {
                if (x % 2 == 0)
                    return x;
                return 0;
            });

            Console.WriteLine("Largest Even Element : {0}", largestEvenElement);
        }

        public void GetMaxAge()
        {

            IList<StudentClass> students = new List<StudentClass>()
            {
                new StudentClass(){StudentID = 1,StudentName="John",Age=13},
                new StudentClass(){StudentID=2,StudentName="Moin",Age=21},
                new StudentClass(){StudentID=3,StudentName="Bill",Age=18},
                new StudentClass(){StudentID=4,StudentName="Ramesh",Age=20},
                new StudentClass(){StudentID=5,StudentName="Ron",Age=15}
            };
            var stdWithLongName = students.Max();
            Console.WriteLine("Student ID {0}, Student Name : {1}",
                stdWithLongName.StudentID, stdWithLongName.StudentName);

        }
    }

    public class StudentClass : IComparable<StudentClass>
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int CompareTo(StudentClass other)
        {
            if (this.StudentName.Length > other.StudentName.Length)
                return 1;
            return 0;
        }
    }
}
