using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
    All : Checks if all the elements in sequenc statisfies the condition.
    Any : Checks if anyof the element in a sequence satisfied the specified condition
    Contains: checks if sequence contains specified element.
     */
    internal class AllAnyContains
    {

        IList<Student> studentList = new List<Student>()
        {
            new Student(){StudentID = 1,StudentName="John",Age=13 },
            new Student(){StudentID = 2,StudentName="Moin",Age=21 },
            new Student(){StudentID = 3,StudentName="Bill",Age=18 },
            new Student(){StudentID = 4,StudentName="Ram",Age=15 }
        };
        public void GetAllQuery()
        {
            bool areAllStudentsTeenAgers = studentList.All(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(areAllStudentsTeenAgers);

        }

        public void GetAnyQuery()
        {
            bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(isAnyStudentTeenAger);
        }

    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if(x.StudentID == y.StudentID && x.StudentName.ToLower()==y.StudentName.ToLower())
                return true;
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }

    public class ContainOperator
    {
        public void GetContainOperator()
        {
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(3);
            Console.WriteLine(result);
        }

        public void GetStudentContainOps()
        {
            IList<Student> studentList = new List<Student>()
                {
                    new Student(){StudentID = 1,StudentName="John",Age=13 },
                    new Student(){StudentID = 2,StudentName="Moin",Age=21 },
                    new Student(){StudentID = 3,StudentName="Bill",Age=18 },
                    new Student(){StudentID = 4,StudentName="Ram",Age=15 }
                };

            Student std = new Student() { StudentID = 3, StudentName = "Bill" };

            bool result = studentList.Contains(std,new StudentComparer());
            Console.WriteLine(result);

        }

    }
}
