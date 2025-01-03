using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * Set Operator : Distinct =====> Return Distinct values from a collection.
     *
     */
    internal class SetOperator_Distinct
    {
        public void Get_Distinct()
        {
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };

            var distinctList = strList.Distinct();
            foreach (var item in distinctList)
            {
                Console.WriteLine(item);
            }
        }

        public void Get_DistinctStudent()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName="John",Age=18},
                new Student(){StudentID = 2,StudentName="Steve",Age=15 },
                new Student(){ StudentID = 3,StudentName="Bill",Age=25 },
                new Student(){ StudentID = 3,StudentName="Bill",Age=25 },
                new Student(){ StudentID = 3,StudentName="Bill",Age=25 },
                new Student(){ StudentID = 3,StudentName="Bill",Age=25 },
                new Student{ StudentID = 5,StudentName="Ron",Age=19 }
            };
            var distinctStudent = studentList.Distinct(new StudentCompare());

            foreach (var item in distinctStudent)
            {
                Console.WriteLine(item.StudentName);
            }
        }
    }

    public class StudentCompare : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && 
                x.StudentName.ToLower() == y.StudentName.ToLower())
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}
