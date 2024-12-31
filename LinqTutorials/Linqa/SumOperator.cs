using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     Sum: Sum() method calculate sum of numric item in collection.
     */
    internal class SumOperator
    {
        public void SumOfIntList()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            var total = intList.Sum();
            Console.WriteLine(total);

            var evenTotal = intList.Sum(x =>
            {
                if (x % 2 == 0)
                    return x;
                return 0;
            });

            Console.WriteLine(evenTotal);


        }

        public void SumOfAtudentAge()
        {
            IList<Student> students = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName="John",Age=13},
                new Student(){StudentID=2,StudentName="Moin",Age=21},
                new Student(){StudentID=3,StudentName="Bill",Age=18},
                new Student(){StudentID=4,StudentName="Ram",Age=20},
                new Student(){StudentID=5,StudentName="Ron",Age=15}
            };

            var sumOfAge=students.Sum(x => x.Age);

            Console.WriteLine("Sum of All Student Age : {0}",sumOfAge);

            var numOfAdult = students.Sum(x =>
            {
                if (x.Age >= 18)
                    return 1;
                return 0;
            });

            Console.WriteLine("Numbet of Adult Student in class : {0}", numOfAdult);
        }
    }
}
